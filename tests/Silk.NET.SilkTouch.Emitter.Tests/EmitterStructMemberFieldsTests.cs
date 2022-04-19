// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;
using Silk.NET.SilkTouch.Symbols;
using Xunit;

namespace Silk.NET.SilkTouch.Emitter.Tests;

public class EmitterStructMemberFieldsTests : EmitterTest
{
    [Fact]
    public void StructWithSingleFieldIntegration()
    {
        var node = Transform
        (
            new StructSymbol
            (
                new IdentifierSymbol("Test"), (new[]
                {
                    (MemberSymbol) new FieldSymbol
                    (
                        new StructSymbol(new IdentifierSymbol("int"), ImmutableArray<MemberSymbol>.Empty),
                        new IdentifierSymbol("F1")
                    )
                }).ToImmutableArray()
            )
        );

        Assert.Equal
        (
            @"public struct Test
{
    public int F1;
}", node.ToFullString()
        );
    }
}