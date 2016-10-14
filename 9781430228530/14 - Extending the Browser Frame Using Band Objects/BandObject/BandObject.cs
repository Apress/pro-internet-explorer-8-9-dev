using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

using Microsoft.Win32;

using SHDocVw;

using ProIeDev.BandObjectDemo.Interop.Constants;
using ProIeDev.BandObjectDemo.Interop.Interfaces;
using ProIeDev.BandObjectDemo.Interop.Structs;
using ProIeDev.BandObjectDemo.Interop.Enums;

namespace ProIeDev.BandObjectDemo.BandObject
{

    /// <summary>
    /// 
    /// </summary>
    public class BandObject : UserControl, 
                              IObjectWithSite,  
                              IDeskBand, IDockingWindow, 
                              IOleWindow//, IOleCommandTarget
    {

        #region Static Members
        
        public static string ClassId;
        public static string ProgId;
        public static string ObjectTitle;
        public static string ObjectName;
        public static string HelpText;

        public static new Size InitialSize;
        public static Size MinSize;
        public static Size MaxSize;
        public static Size IntegralSize;

        public static BandObjectTypes Style = BandObjectTypes.HorizontalExplorerBar;

        #endregion Static Members

        #region Instance Members

        public SHDocVw.WebBrowserClass WebBrowser;
        public SHDocVw.InternetExplorer BandObjectSite;

        #endregion Instance Members

        #region Virtual Methods

        /// <summary>
        /// Defines metadata for class instances that derive from the
        /// BandObject base class
        /// </summary>
        public virtual void DefineMetadata() { }

        #endregion Virtual Methods

        #region IObjectWithSite Interface Implementation

        /// <summary>
        /// Provides the site's IUnknown pointer to the object.
        /// </summary>
        /// <param name="pUnkSite">
        /// An interface pointer to the site managing this object. If NULL, the
        /// object should call IUnknown::Release to release the existing site.
        /// </param>
        public void SetSite(object pUnkSite)
        {

            // Clear out old references to the band object site
            if (!(pUnkSite is SHDocVw.InternetExplorer))
            {
                if (BandObjectSite != null)
                {
                    Marshal.ReleaseComObject(BandObjectSite);
                    BandObjectSite = null;
                }
                return;
            }

            try
            {

                // Set the band object site to be a reference to the current
                // site passed to this function
                BandObjectSite = (SHDocVw.InternetExplorer)pUnkSite;

                // Grab an IServiceProvider instance from the band object site
                ProIeDev.BandObjectDemo.Interop.Interfaces.IServiceProvider serviceProvider =
                    (ProIeDev.BandObjectDemo.Interop.Interfaces.IServiceProvider)
                        BandObjectSite;

                // Create variables to be referenced in a call to QueryService
                object pUnknown = null;
                Guid guid = new Guid(IID.IID_IWebBrowserApp);
                Guid riid = new Guid(IID.IID_IUnknown);

                // Query the service provider to the IWebBrowser instnace
                serviceProvider.QueryService(ref guid, ref riid, out pUnknown);

                // Cast the returned site to an IWebBrowser instance and save
                // it to an instance variable
                WebBrowser = (SHDocVw.WebBrowserClass)Marshal.CreateWrapperOfType(
                    pUnknown as IWebBrowser, typeof(SHDocVw.WebBrowserClass));

                // Create variables to be used in a call to the ShowBrowserBar
                // function on the new IWebBrowser instance
                object pvaClsid = (object)ClassId;
                object pvarSize = null;
                object pvarShowTrue = (object)true;

                // Call the ShowBrowserBar function on the retrieved IWebBrowser
                // instance to display the current band object
                WebBrowser.ShowBrowserBar(ref pvaClsid, ref pvarShowTrue, ref pvarSize);
                
            }
            catch (Exception) { }

        }

        /// <summary>
        /// Gets the last site set with IObjectWithSite::SetSite. If there 
        /// is no known site, the object returns a failure code.
        /// </summary>
        /// <param name="riid"></param>
        /// <param name="ppvSite"></param>
        public void GetSite(ref Guid riid, out object ppvSite)
        {
            // Return the current band object site
            ppvSite = BandObjectSite;
        }

        #endregion IObjectWithSite Interface Implementation

        #region IDeskBand Interface Implementation

        /// <summary>
        /// Gets the information for a band object.
        /// </summary>
        /// <param name="dwBandID">
        /// The identifier of the band. The container assigns this identifier.
        /// The band object can keep this value if it is required.
        /// </param>
        /// <param name="dwViewMode">
        /// The view mode of the band object.
        /// </param>
        /// <param name="pdbi">
        /// A pointer to a DESKBANDINFO structure that receives the band 
        /// information for the object. The dwMask member of this structure 
        /// indicates what information is requested.
        /// </param>
        public void GetBandInfo(uint dwBandID, uint dwViewMode, ref DESKBANDINFO pdbi)
        {
            try
            {

                // Apply a title to the DeskBand object
                if ((pdbi.dwMask & DBIM.TITLE) == DBIM.TITLE)
                    pdbi.wszTitle = ObjectTitle;

                // Apply a width and height to the object
                if ((pdbi.dwMask & DBIM.ACTUAL) == DBIM.ACTUAL)
                {
                    pdbi.ptActual.X = InitialSize.Width;
                    pdbi.ptActual.Y = InitialSize.Height;
                }

                // Apply a maximum width and height to the object
                if ((pdbi.dwMask & DBIM.MAXSIZE) == DBIM.MAXSIZE)
                {
                    pdbi.ptMaxSize.X = MaxSize.Width;
                    pdbi.ptMaxSize.Y = MaxSize.Height;
                }

                // Apply a minimum width and height to the object
                if ((pdbi.dwMask & DBIM.MINSIZE) == DBIM.MINSIZE)
                {
                    pdbi.ptMinSize.X = MinSize.Width;
                    pdbi.ptMinSize.Y = MinSize.Height;
                }

                // Apply an integral width and height to the object
                if ((pdbi.dwMask & DBIM.INTEGRAL) == DBIM.INTEGRAL)
                {
                    pdbi.ptIntegral.X = IntegralSize.Width;
                    pdbi.ptIntegral.Y = IntegralSize.Height;
                }

                // Apply a backcolor to the object
                if ((pdbi.dwMask & DBIM.BKCOLOR) == DBIM.BKCOLOR)
                    pdbi.dwMask &= ~DBIM.BKCOLOR;

                // Apply object mode flags to teh toolbar
                if (Style == BandObjectTypes.Toolbar)
                    pdbi.dwModeFlags = DBIMF.BREAK | DBIMF.ALWAYSGRIPPER;

                // Apply general mode flags
                if ((pdbi.dwMask & DBIM.MODEFLAGS) == DBIM.MODEFLAGS)
                    pdbi.dwModeFlags = DBIMF.VARIABLEHEIGHT | DBIMF.NORMAL;

            }
            catch (Exception) { }
        }

        #endregion IDeskBand Interface Implementation

        #region IOleWindow Interface Implementation
        
        /// <summary>
        /// Retrieves a handle to one of the windows participating in in-place 
        /// activation (frame, document, parent, or in-place object window).
        /// </summary>
        /// <param name="phwnd"></param>
        public void GetWindow(out IntPtr phwnd)
        {
            // Return the current window handle
            phwnd = Handle;
        }

        /// <summary>
        /// Determines whether context-sensitive help mode should be entered 
        /// during an in-place activation session.
        /// </summary>
        /// <param name="fEnterMode"></param>
        public void ContextSensitiveHelp(bool fEnterMode)
        {

            // Perform no action and return
            return;

        }

        #endregion IOleWindow Interface Implementation

        #region IDockingWindow Interface Implementation

        /// <summary>
        /// Notifies the docking window object that it is about to be removed 
        /// from the frame. The docking window object should save any 
        /// persistent information at this time.
        /// </summary>
        /// <param name="dwReserved"></param>
        public void CloseDW(uint dwReserved)
        {
            // Dispose of the current object
            Dispose(true);
        }

        /// <summary>
        /// Notifies the docking window object that the frame's border space 
        /// has changed. In response to this method, the IDockingWindow 
        /// implementation must call SetBorderSpaceDW, even if no border 
        /// space is required or a change is not necessary.
        /// </summary>
        /// <param name="prcBorder">
        /// Pointer to a RECT structure that contains the frame's available 
        /// border space.
        /// </param>
        /// <param name="punkToolbarSite">
        /// Pointer to the site's IUnknown interface. The docking window 
        /// object should call the QueryInterface method for this interface, 
        /// requesting IID_IDockingWindowSite. The docking window object 
        /// then uses that interface to negotiate its border space. It is the 
        /// docking window object's responsibility to release this interface 
        /// when it is no longer needed.
        /// </param>
        /// <param name="fReserved">
        /// Reserved. This parameter should always be zero.
        /// </param>
        public void ResizeBorderDW(IntPtr prcBorder, object punkToolbarSite, bool fReserved)
        {
            // Perform no action and return
            return;
        }

        /// <summary>
        /// Instructs the docking window object to show or hide itself.
        /// </summary>
        /// <param name="bShow">
        /// TRUE if the docking window object should show its window. FALSE if
        /// the docking window object should hide its window and return its 
        /// border space by calling SetBorderSpaceDW with zero values.
        /// </param>
        public void ShowDW(bool bShow)
        {
            // If bShow is true, show the user control; otherwise hide it
            if (bShow) Show();
            else Hide();
        }

        #endregion IDockingWindow Interface Implementation
        /*
        #region IOLECommandTarget Interface Implementation

        /// <summary>
        /// Queries the object for the status of one or more commands generated 
        /// by user interface events
        /// </summary>
        /// <param name="pguidCmdGroup">
        /// The unique identifier of the command group; can be NULL to specify 
        /// the standard group. All the commands that are passed in the prgCmds 
        /// array must belong to the group specified by pguidCmdGroup.
        /// </param>
        /// <param name="cCmds">
        /// The number of commands in the prgCmds array.
        /// </param>
        /// <param name="prgCmds">
        /// A caller-allocated array of OLECMD structures that indicate the 
        /// commands for which the caller needs status information. This method 
        /// fills the cmdf member of each structure with values taken from the 
        /// OLECMDF enumeration.
        /// </param>
        /// <param name="pCmdText">
        /// A pointer to an OLECMDTEXT structure in which to return name and/or 
        /// status information of a single command. This parameter can be NULL 
        /// to indicate that the caller does not need this information.
        /// </param>
        /// <returns>This method returns S_OK on success. </returns>
        public int QueryStatus(ref Guid pguidCmdGroup, uint cCmds, OLECMD[] prgCmds, IntPtr pCmdText)
        {
            // Always return (-1)
            return -1;
        }

        /// <summary>
        /// Executes the specified command or displays help for the command
        /// </summary>
        /// <param name="pguidCmdGroup">
        /// The unique identifier of the command group; can be NULL to specify 
        /// the standard group.
        /// </param>
        /// <param name="nCmdID">
        /// The command to be executed. This command must belong to the group 
        /// specified with pguidCmdGroup.
        /// </param>
        /// <param name="nCmdexecopt">
        /// Specifies how the object should execute the command. Possible 
        /// values are taken from the OLECMDEXECOPT and 
        /// OLECMDID_WINDOWSTATE_FLAG enumerations.
        /// </param>
        /// <param name="pvaIn">
        /// A pointer to a VARIANTARG structure containing input arguments. 
        /// This parameter can be NULL.
        /// </param>
        /// <param name="pvaOut">
        /// Pointer to a VARIANTARG structure to receive command output. This 
        /// parameter can be NULL.
        /// </param>
        /// <returns>This method returns S_OK on success.</returns>
        public int Exec(ref Guid pguidCmdGroup, uint nCmdID, uint nCmdexecopt, IntPtr pvaIn, IntPtr pvaOut)
        {
            // Always return (-1)
            return -1;
        }

        #endregion IOLECommandTarget Interface Implementation
        */
        #region COM Registration Methods

        /// <summary>
        /// Performs COM registration for the the current library
        /// </summary>
        /// <param name="t"></param>
        [ComRegisterFunction]
        public static void Register(Type t)
        {

            // Call the define metadata function for the class instance
            // implementing this base class
            ((BandObject)Activator.CreateInstance(t)).DefineMetadata();

            try
            {

                // Open the HKEY_CLASSES_ROOT\CLSID key and create the subkey
                // for the extension's GUID
                RegistryKey classIdKey = Registry.ClassesRoot.CreateSubKey(@"CLSID\" + ClassId);
                {

                    // Set the default value to be the object name
                    classIdKey.SetValue("", ObjectName);

                    // Set the menu text to be the object name
                    classIdKey.SetValue("MenuText", ObjectName);

                    // Set the help text to the help text value
                    classIdKey.SetValue("HelpText", HelpText);

                    // Create the Implemented Categories key
                    RegistryKey implementedCategoriesKey = classIdKey.CreateSubKey("Implemented Categories");
                    {

                        // Implement the band object subkey
                        implementedCategoriesKey.CreateSubKey("{62C8FE65-4EBB-45e7-B440-6E39B2CDBF29}");

                        // If the extension is a horizontal explorer bar,
                        // implement the horizontal explorer bar category
                        if (Style == BandObjectTypes.HorizontalExplorerBar)
                            implementedCategoriesKey.CreateSubKey("{00021494-0000-0000-C000-000000000046}");

                        // If the extension is a vertical explorer bar,
                        // implement the vertical explorer bar category
                        if (Style == BandObjectTypes.VerticalExplorerBar)
                            implementedCategoriesKey.CreateSubKey("{00021493-0000-0000-C000-000000000046}");

                    }

                    // Create the InprocServer32 key, indicating what
                    // libraries are required by this one for in-process load
                    RegistryKey inprocServer32Key = classIdKey.CreateSubKey("InprocServer32");
                    {

                        // Register the .NET component library for this control
                        inprocServer32Key.SetValue("", "mscoree.dll");
                        inprocServer32Key.SetValue("Assembly", t.Assembly.ToString());
                        inprocServer32Key.SetValue("Class", t.ToString());
                        inprocServer32Key.SetValue("CodeBase", t.Assembly.CodeBase);
                        inprocServer32Key.SetValue("RuntimeVersion", t.Assembly.ImageRuntimeVersion);
                        inprocServer32Key.SetValue("ThreadingModel", "Apartment");

                        RegistryKey versionKey = inprocServer32Key.CreateSubKey("1.0.0.0");
                        {

                            versionKey.SetValue("Assembly", t.Assembly.ToString());
                            versionKey.SetValue("Class", t.ToString());
                            versionKey.SetValue("CodeBase", t.Assembly.CodeBase);
                            versionKey.SetValue("RuntimeVersion", t.Assembly.ImageRuntimeVersion);

                        }

                    }

                    // Create the ProgId subkey to attach the library ProgId to
                    // the new ClassId
                    RegistryKey progIdKey = classIdKey.CreateSubKey("ProgId");
                    {

                        // Set the ProgId to be the string data of the 
                        // default value
                        progIdKey.SetValue("", ProgId);

                    }

                    // Create the instance key
                    RegistryKey instanceKey = classIdKey.CreateSubKey("Instance");
                    {

                        // Set the instance ClassId
                        instanceKey.SetValue("CLSID", "{E31EAE3B-65E1-4D56-A3D0-9E653D978A9A}");

                        // Create an emptry property bag
                        RegistryKey initPropertyBagKey = instanceKey.CreateSubKey("InitPropertyBag");
                        {

                            initPropertyBagKey.SetValue("Url", "");

                        }

                    }

                }

                // If the object type is a toolbar, add information to the
                // Internet Explorer toolbar registry key
                if (Style == BandObjectTypes.Toolbar)
                {

                    // Open up the Internet Explorer toolbar reg key
                    RegistryKey toolbarsKey = Registry.LocalMachine.CreateSubKey(
                        @"SOFTWARE\Microsoft\Internet Explorer\Toolbar");
                    {

                        // Add a new string value whose value name is the
                        // class id of the current object and whose data
                        // is the name of the extension
                        toolbarsKey.SetValue(ClassId, ObjectName);

                    }

                }

                // If the extension type is either a horizontal or a vertical
                // explorer bar, add relevant IE reg keys
                if (Style == BandObjectTypes.HorizontalExplorerBar ||
                    Style == BandObjectTypes.VerticalExplorerBar)
                {

                    // Add a new registry key within the Internet Explorer
                    // explorer bar key whose key name is the classId of the
                    // current item (sans the braces { and } )
                    RegistryKey explorerBarsKey = Registry.CurrentUser.CreateSubKey(
                        @"SOFTWARE\Microsoft\Internet Explorer\Explorer Bars\" + ClassId.Replace("{","").Replace("}",""));
                    {

                        // If the explorer bar type is horizontal, set the
                        // initial bar size to be the initial height
                        if (Style == BandObjectTypes.HorizontalExplorerBar)
                            explorerBarsKey.SetValue("BarSize", BitConverter.GetBytes(InitialSize.Height));

                        // If the explorer bar type is vertical, set the
                        // initial bar size to be the initial width
                        if (Style == BandObjectTypes.VerticalExplorerBar)
                            explorerBarsKey.SetValue("BarSize", BitConverter.GetBytes(InitialSize.Width));

                    }

                    // Open up the component categories key
                    RegistryKey componentCategoriesKey = Registry.CurrentUser.CreateSubKey(
                        @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Discardable\" +
                        @"PostSetup\Component Categories\");
                    {

                        // If the key is not null, continue
                        if (componentCategoriesKey != null)
                        {

                            // Grab the list of component category subkeys
                            string[] categoryKeys = componentCategoriesKey.GetSubKeyNames();

                            // Loop through each key
                            foreach (string categoryKey in categoryKeys)
                            {

                                // If category key is the horizontal explorer
                                // bar category, delete it; this will force IE
                                // to refresh the list of explorer bars
                                if (categoryKey == "{00021494-0000-0000-C000-000000000046}")
                                {
                                    RegistryKey horizontalCategoryKey =
                                        componentCategoriesKey.OpenSubKey(
                                        "{00021494-0000-0000-C000-000000000046}", true);
                                    {

                                        // Delete the enum subkey
                                        horizontalCategoryKey.DeleteSubKey("Enum", false);

                                    }

                                }

                                // If category key is the vertical explorer
                                // bar category, delete it; this will force IE
                                // to refresh the list of explorer bars
                                if (categoryKey == "{00021493-0000-0000-C000-000000000046}")
                                {
                                    RegistryKey verticalCategoryKey =
                                        componentCategoriesKey.OpenSubKey(
                                        "{00021493-0000-0000-C000-000000000046}", true);
                                    {

                                        // Delete the enum subkey
                                        verticalCategoryKey.DeleteSubKey("Enum", false);

                                    }

                                }

                            }

                        }

                    }

                }

            }
            catch (Exception) { }

        }

        /// <summary>
        /// Performs COM unregistration for the current library
        /// </summary>
        [ComUnregisterFunction]
        public static void Unregister()
        {
            try
            {

                // Access the CLSID key in the registry
                RegistryKey clsidKey = Registry.ClassesRoot.OpenSubKey("CLSID", true);
                {

                    // Delete the subkey containing the ClassID if possible
                    clsidKey.DeleteSubKey(ClassId);

                }

            }
            catch (Exception) { }
        }

        #endregion COM Registration Methods

    }

}