using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ProIeDev
{

    [Guid("F1A732D4-5924-4DA7-85D7-4808BD7E6818")]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface AxSampleEventsEvents
    {
        // Expose the OnClick event with DISPID 0x1
        [DispId(0x1)]
        void OnClick();
    }
}
