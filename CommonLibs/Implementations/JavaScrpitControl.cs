using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibs.Contracts;
using OpenQA.Selenium;

namespace CommonLibs.Implementations
{
    public class JavaScrpitControl : IJavaScriptControl
    {
        private readonly IJavaScriptExecutor jsEngine;

        public JavaScrpitControl(IWebDriver driver) => jsEngine = (IJavaScriptExecutor)driver;

        public void executeJavaScript(string scriptToExecute) => jsEngine.ExecuteScript(scriptToExecute);

        public string executeJavaScriptWithReturnValue(string scriptToExecute) => jsEngine.ExecuteScript(scriptToExecute).ToString();

        public void scrollDown(int x, int y)
        {
            string jsCommand = String.Format("window.scrollBy(%d,%d)", x, y);

            executeJavaScript(jsCommand);
        }
    }
}
