using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ProIeDev.ToolbarButtonComObjectReg {

   /// <summary>
   /// Contains the main entrypoint for this application
   /// </summary>
   class Program {

      /// <summary>
      /// Main entrypoint for this application
      /// </summary>
      /// <param name="args">Command line args</param>
      static void Main(string[] args) {

         //  If no argument was passed or too many were passed,
         //  exit the application
         if (args.Length != 1) return;

         //  Switch on the argument passed into the app
         switch (args[0].Trim().ToLower()) {

            //  Installation argument
            case "-i": {

               //  Attempt to register the assembly
               Assembly assembly = Assembly.LoadFile(
                  String.Format(
                     @"{0}\{1}.dll",
                     ProIeDev.ToolbarButtonComObject.Classes.Utils.AssemblyDirectory,
                     ProIeDev.ToolbarButtonComObject.Plugin.AssemblyName
                     )
                  );
               RegistrationServices regasm = new RegistrationServices();
               regasm.RegisterAssembly(assembly, AssemblyRegistrationFlags.SetCodeBase);

               //  Exit the application
               return;

            }

            //  Uninstallation argument
            case "-u": {

               //  Attempt to unregister the assembly
               Assembly assembly = Assembly.LoadFile(
                  String.Format(
                     @"{0}\{1}.dll",
                     ProIeDev.ToolbarButtonComObject.Classes.Utils.AssemblyDirectory,
                     ProIeDev.ToolbarButtonComObject.Plugin.AssemblyName
                     )
                  );
               RegistrationServices regasm = new RegistrationServices();
               regasm.UnregisterAssembly(assembly);

               //  Exit the application
               return;

            }

         }

      }

   }

}