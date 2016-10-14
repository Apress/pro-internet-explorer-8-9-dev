using System;
using System.Collections.Generic;
using System.Text;

namespace ProIeDev
{
    internal class NativeMethods
    {

        internal static class OLEMISC
        {

            internal const int OLEMISC_RECOMPOSEONRESIZE = 1;
            internal const int OLEMISC_ONLYICONIC = 2;
            internal const int OLEMISC_INSERTNOTREPLACE = 4;
            internal const int OLEMISC_STATIC = 8;
            internal const int OLEMISC_CANTLINKINSIDE = 16;
            internal const int OLEMISC_CANLINKBYOLE1 = 32;
            internal const int OLEMISC_ISLINKOBJECT = 64;
            internal const int OLEMISC_INSIDEOUT = 128;
            internal const int OLEMISC_ACTIVATEWHENVISIBLE = 256;
            internal const int OLEMISC_RENDERINGISDEVICEINDEPENDENT = 512;
            internal const int OLEMISC_INVISIBLEATRUNTIME = 1024;
            internal const int OLEMISC_ALWAYSRUN = 2048;
            internal const int OLEMISC_ACTSLIKEBUTTON = 4096;
            internal const int OLEMISC_ACTSLIKELABEL = 8192;
            internal const int OLEMISC_NOUIACTIVATE = 16384;
            internal const int OLEMISC_ALIGNABLE = 32768;
            internal const int OLEMISC_SIMPLEFRAME = 65536;
            internal const int OLEMISC_SETCLIENTSITEFIRST = 131072;
            internal const int OLEMISC_IMEMODE = 262144;
            internal const int OLEMISC_IGNOREACTIVATEWHENVISIBLE = 524288;
            internal const int OLEMISC_WANTSTOMENUMERGE = 1048576;
            internal const int OLEMISC_SUPPORTSMULTILEVELUNDO = 2097152;

        }

    }

}