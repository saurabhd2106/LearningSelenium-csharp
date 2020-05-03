using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace MultiApplication.Pages
{
    public class HomePage : BasePage
    {
        private readonly IWebDriver driver;
        public HomePage(IWebDriver driver) : base(driver) => this.driver = driver;

        private IWebElement newCustomerLink => driver.FindElement(By.LinkText("New Customer"));

        private IWebElement customerName => driver.FindElement(By.Name("name"));

        
       
    }
}
