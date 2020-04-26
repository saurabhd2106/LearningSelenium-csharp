using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibs.Contracts;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CommonLibs.Implementations
{
    public class DropDownControl : IDropdown
    {


        public void SelectViaIndex(IWebElement Element, int Index)
        {
            SelectElement select = new SelectElement(Element);
            select.SelectByIndex(Index);
        }

        public void SelectViaValue(IWebElement Element, string Value)
        {
            SelectElement select = new SelectElement(Element);
            select.SelectByValue(Value);
        }

        public void SelectViaVisibleText(IWebElement Element, string VisibleText)
        {
            SelectElement select = new SelectElement(Element);
            select.SelectByText(VisibleText);
        }
    }
}
