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
            CommonBrowserDriver.Driver.Url = "https://qatechhub.com";

            CommonBrowserDriver.Driver.Close();

            
        }
    }
}
