using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace CommonLibs.Implementations
{
    public class CommonDriverTest : Contracts.IDriver
    {

        public IWebDriver Driver { get; private set; }

        public int PageLoadTimeout
        {
            private get { return pageLoadTimeout; }
            set { if (value >= 0) { pageLoadTimeout = value; } }
        }

        private int pageLoadTimeout;

        private int elementDetectionTimeout;


        public int ElementDetectionTimeout
        {

            private get { return elementDetectionTimeout; }

            set
            {
                if (value > 0) { elementDetectionTimeout = value; }
            }
        }

       

        public CommonDriverTest(string BrowserType)
        {

            pageLoadTimeout = 60;
            elementDetectionTimeout = 10;

            CommonBrowserDriver.BrowserType = "chrome";
            Driver = CommonBrowserDriver.Driver;

            Driver.Manage().Cookies.DeleteAllCookies();

            Driver.Manage().Window.Maximize();


        }
        public void CloseAllBrowsers()
        {
            if (Driver != null)
            {
                Driver.Quit();
            }
        }

        public void CloseBrowser()
        {
            if (Driver != null)
            {
                Driver.Close();
            }
        }

        public string GetCurrentUrl()
        {
            return Driver.Url;
        }

        public string GetPageSource()
        {
            return Driver.PageSource;
        }

        public string GetTitle()
        {
            return Driver.Title;
        }

        public void NavigateBackward()
        {
            Driver.Navigate().Back();
        }

        public void NavigateForward()
        {
            Driver.Navigate().Forward();
        }

        public void NavigateToFirstUrl(string url)
        {
            url = url.Trim();

            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadTimeout);

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(elementDetectionTimeout);

            Driver.Url = url;
        }

        public void NavigateToUrl(string url)
        {
            url = url.Trim();

            Driver.Navigate().GoToUrl(url);
        }

        public void Refresh()
        {
            Driver.Navigate().Refresh();
        }
    }
}
