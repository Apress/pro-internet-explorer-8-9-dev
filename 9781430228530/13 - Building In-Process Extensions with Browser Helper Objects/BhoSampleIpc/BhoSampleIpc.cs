using System;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using Microsoft.Win32;
using System.Windows.Forms;
using mshtml;

namespace ProIeDev
{

    [SecurityPermission(SecurityAction.LinkDemand,
        Flags = SecurityPermissionFlag.UnmanagedCode),
    ComVisible(true),
    Guid("A9760E49-86E8-4320-9C3B-35BCAC903C61"),
    ClassInterface(ClassInterfaceType.None)]
    public class BhoSampleIpc : NativeMethods.IObjectWithSite
    {

        public const int S_OK = unchecked(0x00000000);
        public const int E_NOINTERFACE = unchecked((int)0x80004002);

        internal SHDocVw.WebBrowser Browser;

        public int SetSite(object site)
        {
            // If the site is valid, cast as a WebBrowser object and
            // store it in the Browser variable
            if (site != null)
            {
                Browser = (SHDocVw.WebBrowser)site;

                // Add an event handler for the BeforeNavigate2 event
                Browser.BeforeNavigate2 += Browser_BeforeNavigate2;

                // Add an event handler for the NavigationComplete event
                Browser.NavigateComplete2 += Browser_NavigateComplete2;

            }
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

        void Browser_BeforeNavigate2(object pDisp, ref object URL, ref object Flags, ref object TargetFrameName, ref object PostData, ref object Headers, ref bool Cancel)
        {
            // If the site or url is null, do not continue
            if (pDisp == null || URL == null) return;

            // Convert the url object ref to a string
            string url = URL.ToString();

            // Show the url in a message box
            MessageBox.Show("Beginning navigation to: " + url);
        }

        void Browser_NavigateComplete2(object pDisp, ref object URL)
        {
            // If the site or url is null, do not continue
            if (pDisp == null || URL == null) return;

            // Access both the web browser object and the url passed
            // to this event handler
            SHDocVw.WebBrowser browser = (SHDocVw.WebBrowser)pDisp;
            string url = URL.ToString();

            // Grab the document object off of the Web Browser control
            IHTMLDocument2 document = (IHTMLDocument2)Browser.Document;
            if (document == null) return;

            // Report the total number of links on the current page
            MessageBox.Show("Total link in URL " + url + ": \n" +
                document.links.length.ToString());
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