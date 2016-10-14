using System;
using System.Runtime.InteropServices;

namespace ProIeDev
{
    [Guid("16315C17-8797-46F9-BC34-90A62E4C5F1F")]
    public interface IAxSampleEvents
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