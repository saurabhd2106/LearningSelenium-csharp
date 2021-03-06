﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace MultiApplication.Pages
{
    public class LoginPage : BasePage
    {
        private IWebDriver driver;
        private IWebElement username => driver.FindElement(By.Name("uid"));

        private IWebElement password => driver.FindElement(By.Name("password"));

        private IWebElement loginButton => driver.FindElement(By.Name("btnLogin"));

        public LoginPage(IWebDriver driver) : base(driver) => this.driver = driver;

        public void Login(string userEmailId, string userPassword)
        {
            elementControl.SetText(username, userEmailId);
            elementControl.SetText(password, userPassword);
            elementControl.ClickElement(loginButton);
        }


    }
}
