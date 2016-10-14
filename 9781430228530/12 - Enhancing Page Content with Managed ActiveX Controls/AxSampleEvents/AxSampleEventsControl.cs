using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Windows.Forms;

namespace ProIeDev
{

    [ClassInterface(ClassInterfaceType.None)]
    [ComSourceInterfaces(typeof(AxSampleEventsEvents))]
    [Guid("C85CA4EB-3996-444A-91FE-B9045C94AD38")]
    public partial class AxSampleEventsControl : UserControl, IAxSampleEvents
    {

        public string StringPropertyTest { get; set; }
        public int IntPropertyTest { get; set; }

        public string StringFunctionTest()
        {
            // Return a sample string
            return "Test.";
        }

        public void FunctionInputTest(string input)
        {
            // Show the input string in a message box
            MessageBox.Show(input);
        }

        public AxSampleEventsControl()
        {
            // Initialize form components
            InitializeComponent();
        }

        [ComVisible(false)]
        public delegate void OnClickEventHandler();
        public new event OnClickEventHandler OnClick = null;

        private void FireEventButton_Click(object sender, EventArgs e)
        {
            // Show a message box with the current text
            if (null != OnClick) OnClick();
        }

        [ComRegisterFunction()]
        public static void Register(Type type)
        {
            // Open (and create if needed) is the CLSID (GUID) key for
            // this application in the Classes key
            RegistryKey guidKey =
                Registry.ClassesRoot.CreateSubKey(
                    @"CLSID\" + type.GUID.ToString("B"));

            // Create the InprocServer32 key
            RegistryKey inprocKey = guidKey.OpenSubKey("InprocServer32", true);

            // Create the "control" subkey to inform loaders that this
            // is an ActiveX control
            guidKey.CreateSubKey("Control");

            // Create "TypeLib" to specify the typelib GUID associated with the class.
            Guid typeLibGuid = Marshal.GetTypeLibGuidForAssembly(type.Assembly);

            // Create the type library key and set the typelib guid as
            // the data for that key's (Default) string value
            RegistryKey typelibKey = guidKey.CreateSubKey("TypeLib");
            typelibKey.SetValue("", typeLibGuid.ToString("B"),
                RegistryValueKind.String);

            // Set the misc status key, informing hosts of the visibility
            RegistryKey miscStatusKey = guidKey.CreateSubKey("MiscStatus");
            int miscStatus = 
                NativeMethods.OLEMISC.OLEMISC_RECOMPOSEONRESIZE +
                NativeMethods.OLEMISC.OLEMISC_CANTLINKINSIDE +
                NativeMethods.OLEMISC.OLEMISC_INSIDEOUT +
                NativeMethods.OLEMISC.OLEMISC_ACTIVATEWHENVISIBLE +
                NativeMethods.OLEMISC.OLEMISC_SETCLIENTSITEFIRST;
            miscStatusKey.SetValue("", miscStatus.ToString(),
                RegistryValueKind.String);

            // Get the major and minor version values for the application
            int majorVersion;
            int minorVersion;
            Marshal.GetTypeLibVersionForAssembly(
                type.Assembly, out majorVersion, out minorVersion);

            // Create the version key and set the major and minor version
            // as the data to the (Default) string value
            RegistryKey versionKey = guidKey.CreateSubKey("Version");
            versionKey.SetValue("", String.Format(
                "{0}.{1}", majorVersion, minorVersion));
        }

        [ComUnregisterFunction()]
        public static void Unregister(Type type)
        {
            // Delete the CLSID key of the control
            Registry.ClassesRoot.DeleteSubKeyTree(
                @"CLSID\" + type.GUID.ToString("B"));
        }

    }

}