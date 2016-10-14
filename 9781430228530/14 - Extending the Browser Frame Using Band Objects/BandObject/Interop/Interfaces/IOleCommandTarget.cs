using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using ProIeDev.BandObjectDemo.Interop.Structs;

namespace ProIeDev.BandObjectDemo.Interop.Interfaces
{
    [ComImport, Guid("B722BCCB-4E68-101B-A2BC-00AA00404770"), InterfaceType(1)]
    [ComVisible(false)]
    public interface IOleCommandTarget
    {
        [PreserveSig]
        int QueryStatus([In] ref Guid pguidCmdGroup, [In] uint cCmds, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] OLECMD[] prgCmds, [In, Out] IntPtr pCmdText);
        [PreserveSig]
        int Exec([In] ref Guid pguidCmdGroup, [In] uint nCmdID, [In] uint nCmdexecopt, [In] IntPtr pvaIn, [In] IntPtr pvaOut);
    }
}
