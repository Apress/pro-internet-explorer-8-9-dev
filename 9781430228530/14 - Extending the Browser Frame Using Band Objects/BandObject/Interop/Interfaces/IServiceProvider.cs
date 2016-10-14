using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace ProIeDev.BandObjectDemo.Interop.Interfaces
{
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("6d5140c1-7436-11ce-8034-00aa006009fa")]
    [ComVisible(false)]
    public interface IServiceProvider
    {
        void QueryService(
            ref Guid guid,
            ref Guid riid,
            [MarshalAs(UnmanagedType.Interface)] out Object Obj);
    }
}
