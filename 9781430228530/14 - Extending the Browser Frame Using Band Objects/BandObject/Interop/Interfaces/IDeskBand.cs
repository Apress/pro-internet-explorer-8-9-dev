using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using ProIeDev.BandObjectDemo.Interop.Structs;

namespace ProIeDev.BandObjectDemo.Interop.Interfaces
{
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("EB0FE172-1A3A-11D0-89B3-00A0C90A90AC")]
    [ComVisible(false)]
    public interface IDeskBand
    {
        void GetWindow(out System.IntPtr phwnd);
        void ContextSensitiveHelp([In] bool fEnterMode);

        void ShowDW([In] bool fShow);
        void CloseDW([In] UInt32 dwReserved);

        void ResizeBorderDW(
            IntPtr prcBorder,
            [In, MarshalAs(UnmanagedType.IUnknown)] Object punkToolbarSite,
            bool fReserved);

        void GetBandInfo(
            UInt32 dwBandID,
            UInt32 dwViewMode,
            ref DESKBANDINFO pdbi);
    }
}
