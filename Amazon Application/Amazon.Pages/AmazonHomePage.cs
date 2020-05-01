using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Amazon_Application.Amazon.Pages;
using CommonLibs.Implementations;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Amazon_Application.Com.Amazon.Pages
{
    public class AmazonHomePage : BasePage
    {
        private IWebDriver _driver;

        private IWebElement SearchBox => _driver.FindElement(By.Id("twotabsearchtextbox"));

        private IWebElement SearchCategory => _driver.FindElement(By.Id("searchDropdownBox"));

        private IWebElement SearchButton => _driver.FindElement(By.XPath("//input[@value='Go']"));

        private IWebElement SearchResult => _driver.FindElement(By.XPath("//span[contains(text(),'results for')]"));

        

        public AmazonHomePage(IWebDriver driver) : base(driver)
        {
            _driver = driver;

            
        }

        public string SearchProduct(String product, String category)
        {
            bool isAlertPresent = alertControl.CheckAlertIsPresent(2);

            Console.Write(isAlertPresent);

            elementControl.SetText(SearchBox, product);

            dropdownControl.SelectViaVisibleText(SearchCategory, category);

            elementControl.ClickElement(SearchButton);

            string result = elementControl.GetText(SearchResult);

            return result;
        }
    }
}
