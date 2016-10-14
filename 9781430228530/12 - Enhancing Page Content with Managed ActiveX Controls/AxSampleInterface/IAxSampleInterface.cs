using System;
using System.Runtime.InteropServices;

namespace ProIeDev
{
    [Guid("F939EFDB-2E4D-473E-B7E1-C1728F866CEE")]
    public interface IAxSampleInterface
    {
        bool Visible { get; set; }
        bool Enabled { get; set; }
        void Refresh();
        
        string StringPropertyTest { get; set; }
        int IntPropertyTest { get; set; }

        string StringFunctionTest();
        void FunctionInputTest(string input);

    }
}