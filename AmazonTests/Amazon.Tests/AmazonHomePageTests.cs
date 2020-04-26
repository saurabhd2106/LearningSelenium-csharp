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

        ExtentHtmlReporter HtmlReporter;
        ExtentReports extentReports;
        ExtentTest extentTest;

        DataTable testData;

        [SetUp]
        public void InvokeBrowser()
        {
            HtmlReporter = new ExtentHtmlReporter("/Reports/TestHtmlReport.html");
            extentReports = new ExtentReports();

            extentReports.AttachReporter(HtmlReporter);

            extentTest = extentReports.CreateTest("Setup - Invoke Browser");

            extentTest.Log(Status.Info, "Browser Initiated is - Chrome");
            cmnDriver = new CommonDriver("chrome");

            extentTest.Log(Status.Info, "Initializing all classes");
            amazonHomePage = new AmazonHomePage(cmnDriver.Driver);


           testData = ExcelDriver.ReadDataFromExcel("D:/Users/Saurabh Dhingra/source/repos/Learning Selenium/Amazon Application/TestData/InputTestData.xlsx");
        }

        [Test]
        public void SearchProduct()
        {
            extentTest = extentReports.CreateTest("Testcase 1 - Search Product");

            extentTest.Log(Status.Info, "Search Product - IPhone and Category - Electronics");



            string product = "IPhone";
            string category = "Electronics";

            cmnDriver.NavigateToFirstUrl("https://www.amazon.in");

            amazonHomePage.SearchProduct(product, category);


        }

        [TearDown]
        public void CloseBrowser()
        {
            extentTest = extentReports.CreateTest("Tear Down - Close Browser");
            cmnDriver.CloseAllBrowsers();
            extentReports.Flush();
        }
    }
}
