using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace CommonLibs.Implementations
{
    public class CommonDriver : Contracts.IDriver
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



        public CommonDriver(string BrowserType)
        {

            pageLoadTimeout = 60;
            elementDetectionTimeout = 10;

            if (BrowserType.Equals("chrome"))
            {

                ChromeOptions chromeOption = new ChromeOptions
                {
                    AcceptInsecureCertificates = true
                };

              //  enableDisableExtensionsInChromeBrowser(chromeOption);

                chromeOption.AddArgument("disable-infobars");
                Driver = new ChromeDriver(chromeOption);

            }
            else if (BrowserType.Equals("chrome-headless"))
            {
                ChromeOptions chromeOption = new ChromeOptions();

                chromeOption.AddArgument("disable-infobars");
                Driver = new ChromeDriver(chromeOption);
            }
            else if (BrowserType.Equals("firefox"))
            {
                Driver = new FirefoxDriver();
            }

            else
            {
                Driver = new EdgeDriver();
            }

            Driver.Manage().Cookies.DeleteAllCookies();

            Driver.Manage().Window.Maximize();


        }

        private void enableDisableExtensionsInChromeBrowser(ChromeOptions chromeOptions)
        {
            bool setChroPathExtensionEnable = Boolean.Parse(ConfigurationManager.AppSettings["enableChroPathExtension"]);

            if (setChroPathExtensionEnable)
            {
                string chroPathExtentionPath = ConfigurationManager.AppSettings["pathOfChroPathExtension"];
                chromeOptions.AddExtension(chroPathExtentionPath);
            }

        }

        public void CloseAllBrowsers() => Driver?.Quit();

        public void CloseBrowser() => Driver?.Close();


        public string GetCurrentUrl() => Driver.Url;


        public string GetPageSource() => Driver.PageSource;


        public string GetTitle() => Driver.Title;


        public void NavigateBackward() => Driver.Navigate().Back();


        public void NavigateForward() => Driver.Navigate().Forward();

        public void NavigateToFirstUrl(string url)
        {
            url = url.Trim();

            if (!(url.StartsWith("https://") || url.StartsWith("http://")))
            {

                url = "https://" + url;
            }

            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadTimeout);

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(elementDetectionTimeout);

            Driver.Url = url;
        }

        public void NavigateToUrl(string url)
        {
            url = url.Trim();

            Driver.Navigate().GoToUrl(url);
        }

        public void Refresh() => Driver.Navigate().Refresh();
    }
}
