using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace ProIeDev.BandObjectDemo.Interop.Interfaces
{
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("FC4801A3-2BA9-11CF-A229-00AA003D7352")]
    [ComVisible(false)]
    public interface IObjectWithSite
    {
        void SetSite([In, MarshalAs(UnmanagedType.IUnknown)] object site);
        void GetSite(ref Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object site);
    }
}
