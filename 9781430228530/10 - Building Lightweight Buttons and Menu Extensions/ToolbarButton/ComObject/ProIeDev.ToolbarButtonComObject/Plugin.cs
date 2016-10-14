#region Using Directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using Microsoft.Win32;

using ProIeDev.ToolbarButtonComObject.Interfaces;
using ProIeDev.ToolbarButtonComObject.Enums;
using ProIeDev.ToolbarButtonComObject.Forms;
using ProIeDev.ToolbarButtonComObject.Structs;
using System.Reflection;
using ProIeDev.ToolbarButtonComObject.Classes;

#endregion Using Directives

namespace ProIeDev.ToolbarButtonComObject {

   /// <summary>
   /// 
   /// </summary>
   [ComVisible(true), Guid(Plugin.Guid)]
   public class Plugin : IOleCommandTarget {

      #region Constants

      /// <summary>
      /// Guid of this assembly
      /// </summary>
      public const string Guid = @"193BD928-F965-47DD-B9FF-83173B9E20F5";

      /// <summary>
      /// ProgId of this plugin
      /// </summary>
      public const string ProgId = "ProIeDev.ToolbarButtonComObject.Button";

      /// <summary>
      /// Name of the currently executing assembly
      /// </summary>
      public static string AssemblyName = Assembly.GetExecutingAssembly().GetName().Name;

      /// <summary>
      /// Guid of the IE plugin
      /// </summary>
      public const string PluginGuid = "{9651DC31-B70E-4B80-BF02-BA3FF9A50E2B}";
      
      /// <summary>
      /// Registry key where the plugin will be installed
      /// </summary>
      public const string PluginKey = @"SOFTWARE\Microsoft\Internet Explorer\Extensions";
      
      /// <summary>
      /// WoW emulation registry key for the plugin
      /// </summary>
      public const string PluginKeyWow = @"SOFTWARE\Wow6432Node\Microsoft\Internet Explorer\Extensions";
      
      /// <summary>
      /// Hive to install the plugin intos
      /// </summary>
      public static readonly RegistryKey PluginHive = Registry.LocalMachine;

      #endregion Constants

      #region Properties

      /// <summary>
      /// 
      /// </summary>
      public static Settings PluginSettings { 
         get { return new Settings() {

            //  Text shown alongside the toolar button
            { "ButtonText", "ToolbarButtonComObject Example" },

            //  Icon shown for the button's "active" state
            { "HotIcon", Utils.AssemblyDirectory + @"\Resources\Icon.ico" },

            //  Default icon for the button
            { "Icon", Utils.AssemblyDirectory + @"\Resources\Icon.ico" },

            //  Whether or not the button is initially visible
            { "Default Visible", YesNo.Yes },

            //  CLSID of the IE toolbar band object
            { "CLSID", "{1FBA04EE-3024-11D2-8F1F-0000F87ABD16}" },

            //  Guid of the COM component to run when the button
            //  is clicked (this library)
            { "ClsidExtension", "{" + Guid + "}" }

         }; }
      }

      #endregion Properties

      #region Helper Methods

      /// <summary>
      /// Handles the toolbar click event.  This is not a true
      /// event handler, rather a helper method invoked when the
      /// IOleCommandTarget Exec method is called
      /// </summary>
      [STAThread]
      public void OnToolbarButtonClick() {

         //  Create a new instance of the Display form and
         //  show it as a dialog
         Form display = new Display();
         DialogResult result = display.ShowDialog();

         //  Dispose of the form when finished
         display.Dispose();

      }

      #endregion Helper Methods

      #region COM Registration Methods

      /// <summary>
      /// Performs COM and GAC registration services
      /// </summary>
      /// <param name="type"></param>
      [ComRegisterFunction]
      public static void RegisterServer(Type type)
      {

         //  Create a new registry tools object
         RegistryTools registry = new RegistryTools() {
            Hive = PluginHive
            };

         //  This is a 32-bit plugin, so determine if the target
         //  key needs to access a WoW emulation key
         string key =
            String.Format(
               @"{0}\{1}",
               ((Platform.GetPlatform() == PlatformType.X64) ? 
                  PluginKeyWow : PluginKey),
               PluginGuid
               );

         //  Loop through each of the plugin settings and add
         //  them to the registry
         foreach (var setting in PluginSettings) {
            registry.WriteValue(
               key,
               setting.Key, 
               setting.Value,
               RegistryValueKind.String
               );

         }

      }

      /// <summary>
      /// Performs COM and GAC unregistration services
      /// </summary>
      [ComUnregisterFunction]
      public static void UnregisterServer() {

         //  Create a new registry tools object
         RegistryTools registry = new RegistryTools() {
            Hive = PluginHive
            };

         //  This is a 32-bit plugin, so determine if the target
         //  key needs to access a WoW emulation key
         string key =
            String.Format(
               @"{0}\{1}",
               ((Platform.GetPlatform() == PlatformType.X64) ?
                  PluginKeyWow : PluginKey),
               PluginGuid
               );

         //  Loop through each of the plugin settings and
         //  delete them from the registry
         foreach (var setting in PluginSettings)
            registry.DeleteValue(
               key, 
               setting.Key
               );

         //  Delete the plugin key altogether
         registry.DeleteKey(PluginKey);

      }

      #endregion COM Registration Methods

      #region IOleCommandTarget Interface Functions

      /// <summary>
      /// Queries the object for the status of one or more 
      /// commands generated by user interface events.
      /// </summary>
      /// <param name="pguidCmdGroup">The unique identifier of the command group; can be NULL to specify the standard group. All the commands that are passed in the prgCmds array must belong to the group specified by pguidCmdGroup.</param>
      /// <param name="cCmds">The number of commands in the prgCmds array.</param>
      /// <param name="prgCmds">A caller-allocated array of OLECMD structures that indicate the commands for which the caller needs status information. This method fills the cmdf member of each structure with values taken from the OLECMDF enumeration.</param>
      /// <param name="pCmdText">A pointer to an OLECMDTEXT structure in which to return name and/or status information of a single command. This parameter can be NULL to indicate that the caller does not need this information.</param>
      /// <returns>This method returns S_OK on success.</returns>
      public int QueryStatus(
         ref Guid pguidCmdGroup, 
         uint cCmds,
         OLECMD[] prgCmds, 
         IntPtr pCmdText) {

         return -1;

      }

      /// <summary>
      /// Executes the specified command or displays help for the command.
      /// </summary>
      /// <param name="pguidCmdGroup">The unique identifier of the command group; can be NULL to specify the standard group.</param>
      /// <param name="nCmdID">The command to be executed. This command must belong to the group specified with pguidCmdGroup.</param>
      /// <param name="nCmdexecopt">Specifies how the object should execute the command. Possible values are taken from the OLECMDEXECOPT and OLECMDID_WINDOWSTATE_FLAG enumerations.</param>
      /// <param name="pvaIn">A pointer to a VARIANTARG structure containing input arguments. This parameter can be NULL.</param>
      /// <param name="pvaOut">Pointer to a VARIANTARG structure to receive command output. This parameter can be NULL.</param>
      /// <returns>This method returns S_OK on success.</returns>
      public int Exec(ref Guid pguidCmdGroup, uint nCmdID, uint nCmdexecopt, IntPtr pvaIn, IntPtr pvaOut) {

         //  Call the plugin click event helper
         OnToolbarButtonClick();

         return -1;

      }

      #endregion IOleCommandTarget Interface Functions

   }

}