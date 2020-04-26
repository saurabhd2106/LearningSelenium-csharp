using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibs.Contracts;
using OpenQA.Selenium;

namespace CommonLibs.Implementations
{
    class FrameControl : IFramesControl
    {
        IWebDriver driver;

        public FrameControl(IWebDriver driver)
        {

            this.driver = driver;

        }

        public void SwitchToFrame(IWebElement Element)
        {
            driver.SwitchTo().Frame(Element);
        }

        public void SwitchToFrame(string Id)
        {
            driver.SwitchTo().Frame(Id);
        }

        public void SwitchToFrame(int Index)
        {
            driver.SwitchTo().Frame(Index);
        }

        public void SwitchToParentPage()
        {
            driver.SwitchTo().DefaultContent();
        }
    }
}
