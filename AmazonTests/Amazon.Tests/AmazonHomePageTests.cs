using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon_Application.Com.Amazon.Pages;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using CommonLibs.Implementations;
using CommonLibs.Utils;
using NUnit.Framework;

namespace AmazonTests.Amazon.Tests
{
    public class AmazonHomePageTests
    {

        AmazonHomePage amazonHomePage;
        CommonDriver cmnDriver;

        ExtentReport extentReport;

        DataTable testData;

        [SetUp]
        public void InvokeBrowser()
        {

            extentReport = new ExtentReport("/Reports/testHtmlReport.html");

            extentReport.CreateATestCase("Setup - Setting up the pre-requisites for the test cases");

            extentReport.AddTestLog(Status.Info, "Initializing chrome browser");
            cmnDriver = new CommonDriver("chrome");

            extentReport.AddTestLog(Status.Info, "Initializing all web pages");
            amazonHomePage = new AmazonHomePage(cmnDriver.Driver);


            testData = ExcelDriver.ReadDataFromExcel("D:/Users/Saurabh Dhingra/source/repos/Learning Selenium/Amazon Application/TestData/InputTestData.xlsx");
        }

        [Test]
        public void SearchProduct()
        {
            extentReport.CreateATestCase("Test case 001 - Search Product Functionality");


            string product = "IPhone";
            extentReport.AddTestLog(Status.Info, "Product searched - " + product);

            string category = "Electronics";
            extentReport.AddTestLog(Status.Info, "Category searched - " + category);

            string url = "https://www.amazon.in";

            cmnDriver.NavigateToFirstUrl(url);
            extentReport.AddTestLog(Status.Info, "Navigating to URL - " + url);


            amazonHomePage.SearchProduct(product, category);
            extentReport.AddTestLog(Status.Info, "Searching Product done");

        }

        [TearDown]
        public void CloseBrowser()
        {
            extentReport.AddTestLog(Status.Info, "Closing all Browsers");
            cmnDriver.CloseAllBrowsers();
            extentReport.FlushExtentReports();
        }
    }
}
