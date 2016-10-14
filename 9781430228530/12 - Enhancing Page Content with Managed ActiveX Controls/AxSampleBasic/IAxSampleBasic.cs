using System;
using System.Runtime.InteropServices;

namespace ProIeDev
{
    [Guid("439CE9A2-FAFF-4751-B4F7-5341AF09DBD7")]
    public interface IAxSampleBasic
    {
        // Properties
        string StringPropertyTest { get; set; }
        int IntPropertyTest { get; set; }
        // Functions
        string StringFunctionTest();
        void FunctionInputTest(string input);
    }
}