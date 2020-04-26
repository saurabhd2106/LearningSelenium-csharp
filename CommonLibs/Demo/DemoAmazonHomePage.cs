using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibs.Implementations;

namespace CommonLibs.Demo
{
    class DemoAmazonHomePage
    {

        static void Main(string[] args)
        {
            CommonDriver commonDriver = new CommonDriver("chrome");

            commonDriver.NavigateToFirstUrl("https://amazon.in");

            ElementControl elementControl = new ElementControl();

            string titleOfThePage = commonDriver.GetTitle();

            Console.WriteLine(titleOfThePage);

            commonDriver.CloseAllBrowsers();
        }
    }
}
