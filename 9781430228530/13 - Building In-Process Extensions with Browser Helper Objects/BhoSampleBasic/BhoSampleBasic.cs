using System;
using System.Collections.Generic;
using System.Text;

namespace ProIeDev
{
    using System;
    using System.IO.Pipes;
    using System.Runtime.InteropServices;
    using System.Security.Permissions;
    using System.Text;
    using Microsoft.Win32;

    namespace ProIeDev
    {

        [SecurityPermission(SecurityAction.LinkDemand,
            Flags = SecurityPermissionFlag.UnmanagedCode),
        ComVisible(true),
        Guid("48DEAC10-D583-4683-9345-3F8A117DE7A5"),
        ClassInterface(ClassInterfaceType.None)]
        public class BhoSampleBasic : NativeMethods
        {

            public const int S_OK = unchecked(0x00000000);
            public const int E_NOINTERFACE = unchecked((int)0x80004002);

            internal SHDocVw.WebBrowser Browser;

            public int SetSite(object site)
            {
                // If the site is valid, cast as a WebBrowser object and
                // store it in the Browser variable
                if (site != null) Browser = (SHDocVw.WebBrowser)site;
                else Browser = null;

                //  Return S_OK
                return S_OK;
            }

            public int GetSite(ref Guid guid, out IntPtr ppvSite)
            {
                // Get the IUnknown for the Browser object
                IntPtr pUnk = Marshal.GetIUnknownForObject(Browser);

                // Request a pointer for the interface
                int hResult = Marshal.QueryInterface(pUnk, ref guid, out ppvSite);

                // Release the object
                Marshal.Release(pUnk);

                // Return the result from the QI call
                return hResult;
            }

            [ComRegisterFunction]
            public static void DllRegisterServer(Type type)
            {
                // Open (and create if needed) the main BHO key
                RegistryKey bhoKey =
                    Registry.LocalMachine.CreateSubKey(
                        @"Software\Microsoft\Windows\CurrentVersion\" +
                        @"Explorer\Browser Helper Objects");

                // Open (and create if needed) the GUID key
                RegistryKey guidKey
                    = bhoKey.CreateSubKey(
                        type.GUID.ToString("B"));

                // Close the open keys
                bhoKey.Close();
                guidKey.Close();
            }

            [ComUnregisterFunction]
            public static void DllUnregisterServer(Type type)
            {
                // Open up the main BHO key
                RegistryKey bhoKey =
                    Registry.LocalMachine.OpenSubKey(
                        @"Software\Microsoft\Windows\CurrentVersion\" +
                        @"Explorer\Browser Helper Objects",
                        true);

                // Delete the GUID key if it exists
                if (bhoKey != null) bhoKey.DeleteSubKey(
                    type.GUID.ToString("B"), false);
            }

        }

    }

}