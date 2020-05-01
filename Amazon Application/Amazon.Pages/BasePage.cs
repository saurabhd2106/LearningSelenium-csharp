using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibs.Implementations;
using OpenQA.Selenium;

namespace Amazon_Application.Amazon.Pages
{
    public class BasePage
    {
        public ElementControl elementControl;
        public DropDownControl dropdownControl;
        public AlertControl alertControl;
        public FrameControl frameControl;
        public JavaScriptControl javascriptControl;


        public BasePage(IWebDriver driver)
        {
            elementControl = new ElementControl();
            dropdownControl = new DropDownControl();
            alertControl = new AlertControl(driver);
        }
    }
}
