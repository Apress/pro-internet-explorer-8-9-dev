using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ProIeDev
{

    [Guid("E9CCAE55-795B-40E2-8C16-0613D337814A")]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface AxSampleSafeEvents
    {

        [DispId(0x1)]
        void OnClick();

    }
}
