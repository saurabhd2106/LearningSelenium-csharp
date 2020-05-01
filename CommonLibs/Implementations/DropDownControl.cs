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
        private SelectElement GetSelect(IWebElement element)
        {
            SelectElement select = new SelectElement(element);

            return select;

        }
        public void SelectViaIndex(IWebElement Element, int Index) => GetSelect(Element).SelectByIndex(Index);

        public void SelectViaValue(IWebElement Element, string Value) => GetSelect(Element).SelectByValue(Value);

        public void SelectViaVisibleText(IWebElement Element, string VisibleText) => GetSelect(Element).SelectByText(VisibleText);
    }
}
