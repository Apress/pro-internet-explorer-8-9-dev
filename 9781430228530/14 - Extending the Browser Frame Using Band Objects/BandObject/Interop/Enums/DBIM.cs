using System;
using System.Collections.Generic;
using System.Text;

namespace ProIeDev.BandObjectDemo.Interop.Enums
{
    [Flags]
    public enum DBIM : uint
    {
        MINSIZE = 0x0001,
        MAXSIZE = 0x0002,
        INTEGRAL = 0x0004,
        ACTUAL = 0x0008,
        TITLE = 0x0010,
        MODEFLAGS = 0x0020,
        BKCOLOR = 0x0040
    }
}
