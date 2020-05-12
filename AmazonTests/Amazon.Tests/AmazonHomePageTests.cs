using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon_Application.Com.Amazon.Pages;
using AmazonTests.Utils;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using CommonLibs.Demo;
using CommonLibs.Implementations;
using CommonLibs.Utils;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace AmazonTests.Amazon.Tests
{

    public class AmazonHomePageTests : BaseTests
    {

        [Test]
        [TestCaseSource(typeof(TestDataFromDatabase), "VerifyDataFromDatabase")]
        public void SearchProduct(string product, string category)
        {

            extentReport.CreateATestCase("Test case 001 - Search Product Functionality");

            extentReport.AddTestLog(Status.Info, "Product searched - " + product);

            extentReport.AddTestLog(Status.Info, "Category searched - " + category);

            string baseUrl = ConfigurationManager.AppSettings["baseUrl"];

            cmnDriver.NavigateToFirstUrl(baseUrl);
            extentReport.AddTestLog(Status.Info, "Navigating to URL - " + baseUrl);

            string actualResult = amazonHomePage.SearchProduct(product, category);

            extentReport.AddTestLog(Status.Info, "Searching Product done");

            Assert.That("1-24 of over 10,000 results for Electronics", Is.EqualTo(actualResult));
        }

    }

}
