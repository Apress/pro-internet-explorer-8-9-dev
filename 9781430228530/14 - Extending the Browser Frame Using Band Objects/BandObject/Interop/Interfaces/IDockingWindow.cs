using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace ProIeDev.BandObjectDemo.Interop.Interfaces
{
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("012dd920-7b26-11d0-8ca9-00a0c92dbfe8")]
    [ComVisible(false)]
    public interface IDockingWindow
    {
        void GetWindow(out System.IntPtr phwnd);
        void ContextSensitiveHelp([In] bool fEnterMode);

        void ShowDW([In] bool fShow);
        void CloseDW([In] UInt32 dwReserved);
        void ResizeBorderDW(
            IntPtr prcBorder,
            [In, MarshalAs(UnmanagedType.IUnknown)] Object punkToolbarSite,
            bool fReserved);
    }
}
