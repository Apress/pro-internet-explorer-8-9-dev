using System;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using Microsoft.Win32;
using System.Windows.Forms;

namespace ProIeDev
{
    public class NativeMethods
    {

        [
        ComVisible(true),
        InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
        Guid("FC4801A3-2BA9-11CF-A229-00AA003D7352")
        ]
        public interface IObjectWithSite
        {
            [PreserveSig]
            int SetSite([MarshalAs(UnmanagedType.IUnknown)] object site);

            [PreserveSig]
            int GetSite(ref Guid guid, out IntPtr ppvSite);
        }

    }
}
