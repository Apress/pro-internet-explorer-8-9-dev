using System;
using System.IO;
using System.Reflection;
using System.Threading;

namespace ProIeDev.ToolbarButtonComObject.Classes {

   /// <summary>
   /// Utility functions for this application
   /// </summary>
   public class Utils {

      /// <summary>
      /// Directory of the current executing assembly
      /// </summary>
      public static string AssemblyDirectory {
         get {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            return Path.GetDirectoryName(path);
         }

      }

   }

}