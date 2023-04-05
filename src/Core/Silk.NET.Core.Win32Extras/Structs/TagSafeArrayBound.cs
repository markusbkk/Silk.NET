// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagSAFEARRAYBOUND")]
    public unsafe partial struct TagSafeArrayBound
    {
        public TagSafeArrayBound
        (
            uint? cElements = null,
            int? lLbound = null
        ) : this()
        {
            if (cElements is not null)
            {
                CElements = cElements.Value;
            }

            if (lLbound is not null)
            {
                LLbound = lLbound.Value;
            }
        }


        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "cElements")]
        public uint CElements;

        [NativeName("Type", "LONG")]
        [NativeName("Type.Name", "LONG")]
        [NativeName("Name", "lLbound")]
        public int LLbound;
    }
}
