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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.KHR
{
    [Extension("KHR_robustness")]
    public unsafe partial class KhrRobustness : NativeExtension<GL>
    {
        public const string ExtensionName = "KHR_robustness";
        [NativeApi(EntryPoint = "glGetGraphicsResetStatusKHR", Convention = CallingConvention.Winapi)]
        public partial KHR GetGraphicsResetStatus();

        [NativeApi(EntryPoint = "glGetnUniformfvKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetnUniformfvKHR", Convention = CallingConvention.Winapi)]
        public partial void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetnUniformivKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetnUniformivKHR", Convention = CallingConvention.Winapi)]
        public partial void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetnUniformuivKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetnUniformuivKHR", Convention = CallingConvention.Winapi)]
        public partial void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glReadnPixelsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReadnPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixelsKHR", Convention = CallingConvention.Winapi)]
        public partial void ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glReadnPixelsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReadnPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixelsKHR", Convention = CallingConvention.Winapi)]
        public partial void ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glReadnPixelsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReadnPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixelsKHR", Convention = CallingConvention.Winapi)]
        public partial void ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glReadnPixelsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReadnPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixelsKHR", Convention = CallingConvention.Winapi)]
        public partial void ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        public unsafe float GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location)
        {
            const uint bufSize = 1;
            // ReturnTypeOverloader
            float ret = default;
            GetnUniform(program, location, bufSize, &ret);
            return ret;
        }

        public unsafe void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // ImplicitCountSpanOverloader
            GetnUniform(program, location, (uint) @params.Length*4, out @params.GetPinnableReference());
        }

        public unsafe void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetnUniform(program, location, (uint) @params.Length*4, out @params.GetPinnableReference());
        }

        public unsafe void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> @params)
        {
            // ImplicitCountSpanOverloader
            GetnUniform(program, location, (uint) @params.Length*4, out @params.GetPinnableReference());
        }

        public unsafe void ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            ReadnPixels(x, y, width, height, format, type, (uint) data.Length, out data.GetPinnableReference());
        }

        public unsafe void ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            ReadnPixels(x, y, width, height, format, type, (uint) data.Length, out data.GetPinnableReference());
        }

        public unsafe void ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            ReadnPixels(x, y, width, height, format, type, (uint) data.Length, out data.GetPinnableReference());
        }

        public unsafe void ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            ReadnPixels(x, y, width, height, format, type, (uint) data.Length, out data.GetPinnableReference());
        }

        public unsafe float GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize)
        {
            // NonKhrReturnTypeOverloader
            GetnUniform(program, location, bufSize, out float silkRet);
            return silkRet;
        }

        public unsafe T0 ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            ReadnPixels(x, y, width, height, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            ReadnPixels(x, y, width, height, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            ReadnPixels(x, y, width, height, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            ReadnPixels(x, y, width, height, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public KhrRobustness(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

