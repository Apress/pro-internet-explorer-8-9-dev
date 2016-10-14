using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using ProIeDev.BandObjectDemo.Interop.Enums;

namespace ProIeDev.BandObjectDemo.Interop.Structs
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [ComVisible(false)]
    public struct DESKBANDINFO
    {
        public DBIM dwMask;
        public Point ptMinSize;
        public Point ptMaxSize;
        public Point ptIntegral;
        public Point ptActual;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 255)]
        public String wszTitle;
        public DBIMF dwModeFlags;
        public Int32 crBkgnd;
    };
}
