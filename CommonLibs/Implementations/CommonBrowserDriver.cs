using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace CommonLibs.Implementations
{
    public class CommonBrowserDriver
    {

        private CommonBrowserDriver()
        {
            BrowserType = "chrome";
        }

        private static string browserType;

        public static string BrowserType
        {
            get { return browserType; }
            set { browserType = value; }
        }


        private static IWebDriver driver;

        public static IWebDriver Driver

        {
            get
            {
                if (driver == null)
                {
                    if (browserType.Equals("chrome"))
                    {
                        driver = new ChromeDriver();
                    } else if(browserType.Equals("edge"))
                    {
                        driver = new EdgeDriver();
                    }
                }
                return driver;
            }
            set { driver = value; }
        }

    }
}
