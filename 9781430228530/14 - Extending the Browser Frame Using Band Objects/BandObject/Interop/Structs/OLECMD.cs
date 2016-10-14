using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace ProIeDev.BandObjectDemo.Interop.Structs
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    [ComVisible(false)]
    public struct OLECMD
    {
        public uint cmdID;
        public uint cmdf;
    }
}
