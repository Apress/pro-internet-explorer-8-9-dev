using System;
using System.Collections.Generic;
using System.Text;

namespace ProIeDev.BandObjectDemo.Interop.Enums
{
    [Flags]
    public enum DBIMF : int
    {
        NORMAL = 0x0000,
        MINSIZE = 0x0001,
        MAXSIZE = 0x0002,
        INTEGRAL = 0x0004,
        VARIABLEHEIGHT = 0x0008,
        TITLE = 0x0010,
        MODEFLAGS = 0x0020,
        BKCOLOR = 0x0040,
        USECHEVRON = 0x0080,
        BREAK = 0x0100,
        ADDTOFRONT = 0x0200,
        TOPALIGN = 0x0400,
        NOGRIPPER = 0x0800,
        ALWAYSGRIPPER = 0x1000,
        NOMARGINS = 0x2000
    }
}
