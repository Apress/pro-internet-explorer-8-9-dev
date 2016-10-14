using System;
using System.Runtime.InteropServices;

namespace ProIeDev
{
    [Guid("F90A065A-CC2A-48F7-B4B4-91FA832941A1")]
    public interface IAxSampleSafe
    {
        bool Visible { get; set; }
        bool Enabled { get; set; }
        
        string StringPropertyTest { get; set; }
        int IntPropertyTest { get; set; }

        string StringFunctionTest();
        void FunctionInputTest(string input);

        void Refresh();


    }
}