using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Windows.Forms;

namespace ProIeDev
{
    public class NativeMethods
    {
        public static class INTERFACESAFE
        {
            public const int INTERFACESAFE_FOR_UNTRUSTED_CALLER = 0x00000001;
            public const int INTERFACESAFE_FOR_UNTRUSTED_DATA = 0x00000002;
        }


        [ComImport]
        [Guid("CB5BDC81-93C1-11CF-8F20-00805F2CD064")]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        public interface IObjectSafety
        {
            [PreserveSig]
            int GetInterfaceSafetyOptions(ref Guid riid, out int pdwSupportedOptions, out int pdwEnabledOptions);

            [PreserveSig]
            int SetInterfaceSafetyOptions(ref Guid riid, int dwOptionSetMask, int dwEnabledOptions);
        }

        public delegate int PropertyNotifySinkHandler(int dispId);

        [ComImport]
        [Guid("9BFBBC02-EFF1-101A-84ED-00AA00341D07")]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        public interface IPropertyNotifySink
        {
            int OnChanged(int dispId);

            [PreserveSig]
            int OnRequestEdit(int dispId);
        }


        public static class OLEMISC
        {

            public const int OLEMISC_RECOMPOSEONRESIZE = 1;
            public const int OLEMISC_ONLYICONIC = 2;
            public const int OLEMISC_INSERTNOTREPLACE = 4;
            public const int OLEMISC_STATIC = 8;
            public const int OLEMISC_CANTLINKINSIDE = 16;
            public const int OLEMISC_CANLINKBYOLE1 = 32;
            public const int OLEMISC_ISLINKOBJECT = 64;
            public const int OLEMISC_INSIDEOUT = 128;
            public const int OLEMISC_ACTIVATEWHENVISIBLE = 256;
            public const int OLEMISC_RENDERINGISDEVICEINDEPENDENT = 512;
            public const int OLEMISC_INVISIBLEATRUNTIME = 1024;
            public const int OLEMISC_ALWAYSRUN = 2048;
            public const int OLEMISC_ACTSLIKEBUTTON = 4096;
            public const int OLEMISC_ACTSLIKELABEL = 8192;
            public const int OLEMISC_NOUIACTIVATE = 16384;
            public const int OLEMISC_ALIGNABLE = 32768;
            public const int OLEMISC_SIMPLEFRAME = 65536;
            public const int OLEMISC_SETCLIENTSITEFIRST = 131072;
            public const int OLEMISC_IMEMODE = 262144;
            public const int OLEMISC_IGNOREACTIVATEWHENVISIBLE = 524288;
            public const int OLEMISC_WANTSTOMENUMERGE = 1048576;
            public const int OLEMISC_SUPPORTSMULTILEVELUNDO = 2097152;

        }


    }

}