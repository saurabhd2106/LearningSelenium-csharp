using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibs.Implementations;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Amazon_Application.Com.Amazon.Pages
{
    public class AmazonHomePage
    {

        [FindsBy(How = How.Id, Using = "twotabsearchtextbox")]
        private IWebElement SearchBox;

        [FindsBy(How = How.Id, Using = "searchDropdownBox")]
        private IWebElement SearchCategory;

        [FindsBy(How = How.XPath, Using = "//input[@value='Go']")]
        private IWebElement SearchButton;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'results for')]")]
        private IWebElement SearchResult;

        ElementControl elementControl = new ElementControl();
        DropDownControl dropdownControl = new DropDownControl();

        public AmazonHomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void SearchProduct(String product, String category)
        {

            elementControl.SetText(SearchBox, product);

            dropdownControl.SelectViaVisibleText(SearchCategory, category);

            elementControl.ClickElement(SearchButton);

            string result = elementControl.GetText(SearchResult);

            Console.WriteLine(value: result);
        }
    }
}
