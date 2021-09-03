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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDevicePerformanceQueryFeaturesKHR")]
    public unsafe partial struct PhysicalDevicePerformanceQueryFeaturesKHR
    {
        public PhysicalDevicePerformanceQueryFeaturesKHR
        (
            StructureType? sType = StructureType.PhysicalDevicePerformanceQueryFeaturesKhr,
            void* pNext = null,
            Bool32? performanceCounterQueryPools = null,
            Bool32? performanceCounterMultipleQueryPools = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (performanceCounterQueryPools is not null)
            {
                PerformanceCounterQueryPools = performanceCounterQueryPools.Value;
            }

            if (performanceCounterMultipleQueryPools is not null)
            {
                PerformanceCounterMultipleQueryPools = performanceCounterMultipleQueryPools.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "performanceCounterQueryPools")]
        public Bool32 PerformanceCounterQueryPools;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "performanceCounterMultipleQueryPools")]
        public Bool32 PerformanceCounterMultipleQueryPools;
    }
}