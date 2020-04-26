using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibs.Contracts;
using OpenQA.Selenium;

namespace CommonLibs.Implementations
{
    public class ElementControl : ICommonElement
    {
        public void ChangeCheckboxStatus(IWebElement Element, bool DesiredState)
        {
            bool CurrentState = Element.Selected;

            if(DesiredState != CurrentState)
            {
                Element.Click();
            }
        }

        public void ClearText(IWebElement Element)
        {
            Element.Clear();
        }

        public void ClickElement(IWebElement Element)
        {

            Element.Click();
           
        }

        public string GetAttribute(IWebElement Element, string attribute)
        {
          return  Element.GetAttribute(attribute);
        }

        public string GetCssValue(IWebElement Element, string cssProperty)
        {
            return Element.GetCssValue(cssProperty);
        }

        public string GetText(IWebElement Element)
        {
            return Element.Text;
        }

        public bool IsElementEnabled(IWebElement Element)
        {
            return Element.Enabled;
        }

        public bool IsElementSelected(IWebElement Element)
        {
            return Element.Selected;
        }

        public bool IsElementVisible(IWebElement Element)
        {
            return Element.Displayed;
        }

        public void SetText(IWebElement Element, string TextToWrite)
        {
            Element.SendKeys(TextToWrite);
        }
    }
}
