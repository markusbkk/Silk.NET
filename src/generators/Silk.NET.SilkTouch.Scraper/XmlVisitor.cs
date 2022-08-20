// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata;
using System.Xml;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Symbols;
using Parameter=Silk.NET.SilkTouch.Symbols.Parameter;
using TypeReference=Silk.NET.SilkTouch.Symbols.TypeReference;

namespace Silk.NET.SilkTouch.Scraper;

internal sealed class XmlVisitor
{
    private readonly ILogger _logger;
    private readonly TypeStore _typeStore;
    public XmlVisitor(ILogger logger, TypeStore typeStore)
    {
        _logger = logger;
        _typeStore = typeStore;
    }

    public IEnumerable<Symbol> Visit(XmlNode node)
    {
        _logger.LogTrace("Visiting XML Node of kind {name} {inner}", node.Name, node.InnerXml);
        switch (node)
        {
            case XmlElement { Name: "bindings" } bindings:
                return VisitBinding(bindings);
            case XmlElement { Name: "namespace" } @namespace:
                return VisitNamespace(@namespace);
            case XmlElement { Name: "struct" } @struct:
                return VisitStruct(@struct);
            case XmlElement { Name: "field" } field:
                return VisitField(field);
            case XmlElement { Name: "class" } @class:
                return VisitClass(@class);
            case XmlElement { Name: "function" } function:
                return VisitFunction(function);
            default:
            {
                _logger.LogWarning("Skipping unknown XML Node of kind {name}", node.Name);
                #if DEBUG
                throw new NotImplementedException();
                #else
                return Array.Empty<Symbol>();
                #endif
            }
        }
    }

    private IEnumerable<Symbol> VisitClass(XmlElement @class)
    {
        var name = @class.Attributes["name"]?.Value;
        if (name is null)
            throw new InvalidOperationException("Class name cannot be null");

        var members = @class.ChildNodes.Cast<XmlNode>()
            .SelectMany
            (
                x =>
                {
                    var results = Visit(x).ToArray();
                    if (results.Any(x => x is not MethodSymbol))
                        throw new NotImplementedException("Class only supports method members for now");
                    return results.OfType<MethodSymbol>();
                }
            );
        return new[]
        {
            new ClassSymbol
            (
                TypeId.CreateNew(),
                new IdentifierSymbol(name, ImmutableArray<ISymbolAnnotation>.Empty),
                members.ToImmutableArray(),
                ImmutableArray<ISymbolAnnotation>.Empty
            )
        };
    }

    private IEnumerable<Symbol> VisitFunction(XmlElement function)
    {
        var name = function.Attributes["name"]?.Value;
        if (name is null)
            throw new InvalidOperationException("Function name cannot be null");

        var returnTypeNode = function.ChildNodes.Cast<XmlNode>().OfType<XmlElement>().FirstOrDefault(x => x.Name == "type");
        if (returnTypeNode is null)
            throw new InvalidOperationException("Could not find return type of function");
        
        var returnType = VisitType(returnTypeNode).Single();
        if (returnType is not TypeReference rt)
            throw new InvalidOperationException("VisitType needs to return single type reference");

        var parameters = function.ChildNodes.Cast<XmlNode>()
            .OfType<XmlElement>()
            .Where(x => x.Name == "param")
            .Select
            (
                x =>
                {
                    var paramName = x.Attributes["name"]?.Value;
                    if (paramName is null)
                        throw new InvalidOperationException("Function parameter name cannot be null");

                    var paramTypeNode = x.ChildNodes.Cast<XmlNode>()
                        .OfType<XmlElement>()
                        .SingleOrDefault(x => x.Name == "type");
                    if (paramTypeNode is null)
                        throw new InvalidOperationException("Parameter type cannot be null");

                    var paramType = VisitType(paramTypeNode).Single();
                    if (paramType is not TypeReference pt)
                        throw new InvalidOperationException("VisitType needs to return single type reference");

                    return new Parameter(pt, new IdentifierSymbol(paramName, ImmutableArray<ISymbolAnnotation>.Empty));
                }
            )
            .ToImmutableArray();

        return new[]
        {
            new StaticExternalMethodSymbol
            (
                rt,
                parameters,
                new IdentifierSymbol(name, ImmutableArray<ISymbolAnnotation>.Empty),
                ImmutableArray<ISymbolAnnotation>.Empty
            )
        };
    }

    private IEnumerable<Symbol> VisitField(XmlElement field)
    {
        var name = field.Attributes["name"]?.Value;
        if (name is null)
        {
            throw new InvalidOperationException("Field requires a name");
        }

        var typeNode = field.ChildNodes.Cast<XmlNode>().SingleOrDefault(x => x.Name == "type") as XmlElement;
        if (typeNode is null)
            throw new InvalidOperationException("Field type cannot be null");

        TypeReference? finalType = null;
        foreach (var type in VisitType(typeNode))
        {
            if (type is null)
            {
                throw new InvalidOperationException
                (
                    $"{nameof(XmlVisitor)}.{nameof(VisitType)} has returned null"
                );
            }
            
            if (type is not TypeReference tr)
            {
                throw new InvalidOperationException
                (
                    $"{nameof(XmlVisitor)}.{nameof(VisitType)} has returned something other then a type reference"
                );
            }

            if (finalType is not null)
            {
                throw new InvalidOperationException
                    ($"{nameof(XmlVisitor)}.{nameof(VisitType)} has returned more then one result");
            }

            finalType = tr;
        }

        if (finalType is null)
        {
            throw new InvalidOperationException
                ($"No type could be resolved from {typeNode.OuterXml}");
        }

        return new[]
        {
            new FieldSymbol
            (
                finalType,
                new IdentifierSymbol(name, ImmutableArray<ISymbolAnnotation>.Empty),
                ImmutableArray<ISymbolAnnotation>.Empty
            )
        };
    }

    // NOTE: This does not visit types as in class/struct, but visits *references* to types. Like from methods or fields.
    private IEnumerable<Symbol> VisitType(XmlElement type)
    {
        return new[]
        {
            new UnresolvedTypeReference(type.InnerText, ImmutableArray<ISymbolAnnotation>.Empty)
        };
    }

    private IEnumerable<Symbol> VisitStruct(XmlElement @struct)
    {
        var fields = new List<FieldSymbol>();
        foreach (var node in @struct.ChildNodes.Cast<XmlNode>())
        {
            var symbols = Visit(node);
            foreach (var v in symbols)
            {
                if (v is FieldSymbol fieldSymbol)
                {
                    fields.Add(fieldSymbol);
                }
            }
        }

        return new[]
        {
            StoreType
            (
                new StructSymbol
                (
                    TypeId.CreateNew(),
                    new IdentifierSymbol
                    (
                        @struct.Attributes?["name"]?.Value ?? throw new InvalidOperationException(),
                        ImmutableArray<ISymbolAnnotation>.Empty
                    ),
                    fields.ToImmutableArray(),
                    ImmutableArray<ISymbolAnnotation>.Empty
                )
            )
        };
    }

    private IEnumerable<Symbol> VisitBinding(XmlElement bindings)
    {
        return bindings.ChildNodes.Cast<XmlNode>().Where(x => x is not null).SelectMany(Visit);
    }

    private IEnumerable<Symbol> VisitNamespace(XmlElement @namespace)
    {
        return new[]
        {
            new NamespaceSymbol
            (
                new IdentifierSymbol
                (
                    @namespace.Attributes?["name"]?.Value ?? throw new InvalidOperationException(),
                    ImmutableArray<ISymbolAnnotation>.Empty
                ),
                @namespace.ChildNodes.Cast<XmlNode>()
                    .SelectMany(Visit)
                    .Select
                    (
                        x =>
                        {
                            if (x is not TypeSymbol ts) throw new InvalidOperationException();
                            return ts;
                        }
                    )
                    .ToImmutableArray(),
                ImmutableArray<ISymbolAnnotation>.Empty
            )
        };
    }

    private T StoreType<T>(T instance) where T : TypeSymbol
    {
        _typeStore.Store(instance);
        return instance;
    }
}