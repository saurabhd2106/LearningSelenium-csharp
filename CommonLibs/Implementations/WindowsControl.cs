using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibs.Contracts;
using OpenQA.Selenium;

namespace CommonLibs.Implementations
{
    class WindowsControl : IWindowControl
    {
        IWebDriver driver;

        public WindowsControl(IWebDriver driver)
        {
            this.driver = driver;
        }
        public string GetWindowHandle()
        {
            return driver.CurrentWindowHandle;
        }

        public ISet<string> GetWindowHandles()
        {
            return driver.WindowHandles.ToHashSet();
        }

        public void SwitchToAnyWindow(string WindowHandle)
        {
            driver.SwitchTo().Window(WindowHandle);
        }

        public void SwitchToAnyWindow(int Index)
        {
            string childWindow = driver.WindowHandles.ToArray()[Index].ToString();

            driver.SwitchTo().Window(childWindow);
        }
    }
}
