using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibs.Contracts;
using CommonLibs.Utils;
using OpenQA.Selenium;

namespace CommonLibs.Implementations
{
    public class AlertControl : IAlertControl
    {
        private readonly IWebDriver _driver;

        public AlertControl(IWebDriver driver) => _driver = driver;
        public void AcceptAlert() => _driver.SwitchTo().Alert().Accept();

        public bool CheckAlertIsPresent(int timeoutInSeconds)
        {
            try
            {
                WaitUtils.WaitTillAlertIsPresent(_driver, timeoutInSeconds);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void DismissAlert() => _driver.SwitchTo().Alert().Dismiss();

        public string GetMessageFromAlert() => _driver.SwitchTo().Alert().Text;
    }
}
