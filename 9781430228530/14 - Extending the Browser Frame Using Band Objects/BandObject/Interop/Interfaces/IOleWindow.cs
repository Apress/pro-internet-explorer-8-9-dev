using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace ProIeDev.BandObjectDemo.Interop.Interfaces
{
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("00000114-0000-0000-C000-000000000046")]
    [ComVisible(false)]
    public interface IOleWindow
    {
        void GetWindow(out System.IntPtr phwnd);
        void ContextSensitiveHelp([In] bool fEnterMode);
    }
}
