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

namespace Silk.NET.DirectComposition
{
    [Guid("2a9e9ead-364b-4b15-a7c4-a1997f78b389")]
    [NativeName("Name", "IDCompositionScaleTransform3D")]
    public unsafe partial struct IDCompositionScaleTransform3D : IComVtbl<IDCompositionScaleTransform3D>, IComVtbl<IDCompositionTransform3D>, IComVtbl<IDCompositionEffect>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("2a9e9ead-364b-4b15-a7c4-a1997f78b389");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDCompositionTransform3D(IDCompositionScaleTransform3D val)
            => Unsafe.As<IDCompositionScaleTransform3D, IDCompositionTransform3D>(ref val);

        public static implicit operator IDCompositionEffect(IDCompositionScaleTransform3D val)
            => Unsafe.As<IDCompositionScaleTransform3D, IDCompositionEffect>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDCompositionScaleTransform3D val)
            => Unsafe.As<IDCompositionScaleTransform3D, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDCompositionScaleTransform3D
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IDCompositionScaleTransform3D*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDCompositionScaleTransform3D*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDCompositionScaleTransform3D*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDCompositionScaleTransform3D*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDCompositionScaleTransform3D*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDCompositionScaleTransform3D*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetScaleX(float scaleX)
        {
            var @this = (IDCompositionScaleTransform3D*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, float, int>)@this->LpVtbl[3])(@this, scaleX);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetScaleY(float scaleY)
        {
            var @this = (IDCompositionScaleTransform3D*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, float, int>)@this->LpVtbl[4])(@this, scaleY);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetScaleZ(float scaleZ)
        {
            var @this = (IDCompositionScaleTransform3D*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, float, int>)@this->LpVtbl[5])(@this, scaleZ);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCenterX(float centerX)
        {
            var @this = (IDCompositionScaleTransform3D*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, float, int>)@this->LpVtbl[6])(@this, centerX);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCenterY(float centerY)
        {
            var @this = (IDCompositionScaleTransform3D*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, float, int>)@this->LpVtbl[7])(@this, centerY);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCenterZ(float centerZ)
        {
            var @this = (IDCompositionScaleTransform3D*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, float, int>)@this->LpVtbl[8])(@this, centerZ);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionScaleTransform3D*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionScaleTransform3D*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
