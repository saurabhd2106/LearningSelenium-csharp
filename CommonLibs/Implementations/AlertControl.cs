using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibs.Contracts;
using OpenQA.Selenium;

namespace CommonLibs.Implementations
{
    class AlertControl : IAlertControl
    {
        IAlert alert;

        public AlertControl(IWebDriver driver)
        {
             alert = driver.SwitchTo().Alert();
        }
        public void AcceptAlert()
        {
            alert.Accept();
        }

        public void CheckAlertIsPresent()
        {
            
        }

        public void DismissAlert()
        {
            alert.Dismiss();
        }

        public string GetMessageFromAlert()
        {
            return alert.Text;
        }
    }
}
