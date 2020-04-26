using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibs.Contracts
{
    interface IWindowControl
    {
        void  SwitchToAnyWindow(string WindowHandle);

        void SwitchToAnyWindow(int Index);

        string GetWindowHandle();

        ISet<string> GetWindowHandles();


    }
}
