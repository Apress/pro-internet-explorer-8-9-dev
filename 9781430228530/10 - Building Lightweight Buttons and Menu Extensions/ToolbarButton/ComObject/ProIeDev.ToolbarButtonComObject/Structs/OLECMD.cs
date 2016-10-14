using System.Runtime.InteropServices;

namespace ProIeDev.ToolbarButtonComObject.Structs {

   /// <summary>
   /// 
   /// </summary>
   [StructLayout(LayoutKind.Sequential, Pack = 4)]
   [ComVisible(false)]
   public struct OLECMD {

      /// <summary>
      /// 
      /// </summary>
      public uint cmdID;

      /// <summary>
      /// 
      /// </summary>
      public uint cmdf;

   }

}