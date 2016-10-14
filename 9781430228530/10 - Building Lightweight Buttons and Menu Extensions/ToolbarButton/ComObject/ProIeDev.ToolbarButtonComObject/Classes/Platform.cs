using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using ProIeDev.ToolbarButtonComObject.Enums;
using ProIeDev.ToolbarButtonComObject.Structs;

namespace ProIeDev.ToolbarButtonComObject.Classes {

   /// <summary>
   /// 
   /// </summary>
   public class Platform {

      internal const ushort PROCESSOR_ARCHITECTURE_INTEL = 0;
      internal const ushort PROCESSOR_ARCHITECTURE_IA64 = 6;
      internal const ushort PROCESSOR_ARCHITECTURE_AMD64 = 9;
      internal const ushort PROCESSOR_ARCHITECTURE_UNKNOWN = 0xFFFF;


      [DllImport("kernel32.dll")]
      internal static extern void GetNativeSystemInfo(ref SYSTEM_INFO lpSystemInfo);

      /// <summary>
      /// Gets the platform of the current system
      /// </summary>
      /// <returns>Platform type</returns>
      public static PlatformType GetPlatform() {

         //  Create a new system information object
         SYSTEM_INFO info = new SYSTEM_INFO();

         //  Query for system information
         GetNativeSystemInfo(ref info);

         //  Switch based on the processor architectore
         switch (info.wProcessorArchitecture) {

            //  If AMD64 || IA64, return X64
            case PROCESSOR_ARCHITECTURE_AMD64:
            case PROCESSOR_ARCHITECTURE_IA64:
               return PlatformType.X64;

            //  If Intel, return Intel
            case PROCESSOR_ARCHITECTURE_INTEL:
               return PlatformType.X86;

            //  If unknown, indicate unknown
            default:
               return PlatformType.Unknown;
         }
      }

   }
}
