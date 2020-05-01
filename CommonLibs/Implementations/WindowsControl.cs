using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibs.Contracts;
using OpenQA.Selenium;

namespace CommonLibs.Implementations
{
    public class WindowsControl : IWindowControl
    {
        private readonly IWebDriver driver;

        public WindowsControl(IWebDriver driver) => this.driver = driver;

        public string GetWindowHandle() => driver.CurrentWindowHandle;

        public ISet<string> GetWindowHandles() => driver.WindowHandles.ToHashSet();

        public void SwitchToAnyWindow(string WindowHandle) => driver.SwitchTo().Window(WindowHandle);

        public void SwitchToAnyWindow(int Index)
        {
            string childWindow = driver.WindowHandles.ToArray()[Index].ToString();

            driver.SwitchTo().Window(childWindow);
        }
    }
}
