using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon_Application.Com.Amazon.Pages;
using AventStack.ExtentReports;
using CommonLibs.Implementations;
using CommonLibs.Utils;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace CommonLibs.Demo
{
    public class BaseTests
    {
        public AmazonHomePage amazonHomePage;
        public CommonDriver cmnDriver;

        public ExtentReport extentReport;

        public string executionStartTime;
        public string currentWorkingDirectory;

        public ScreenshotControl screenshotControl;

        [OneTimeSetUp]
        public void PreSetup()
        {
            executionStartTime = DateTimeUtils.GetCurrentDateAndTime();
            currentWorkingDirectory = "D:/Users/Saurabh Dhingra/source/repos/Learning Selenium/AmazonTests";



            extentReport = new ExtentReport($"{currentWorkingDirectory}/Reports/AmazonTestReport-{executionStartTime}.html");

            extentReport.CreateATestCase("Setup - Setting up the pre-requisites for the test cases");

            extentReport.AddTestLog(Status.Info, "Initializing chrome browser");
        }

        [OneTimeTearDown]
        public void PostCleanUp()
        {
            extentReport.FlushExtentReports();
        }

        [SetUp]
        public void SetUp()
        {
            cmnDriver = new CommonDriver("chrome");

            screenshotControl = new ScreenshotControl(cmnDriver.Driver);

            extentReport.AddTestLog(Status.Info, "Initializing all web pages");

            amazonHomePage = new AmazonHomePage(cmnDriver.Driver);

        }

        [TearDown]
        public void CloseBrowser()
        {
            try
            {

                if (TestContext.CurrentContext.Result.Outcome == ResultState.Failure)
                {
                    extentReport.AddTestLog(Status.Fail, "Test case failed, please check logs or screenshots for failure reason");

                    string screenshotFile = $"{currentWorkingDirectory}/screenshots/test-{executionStartTime}.jpeg";
                    screenshotControl.CaptureAndSaveScreenshot(screenshotFile);

                    extentReport.AddScreenshotInReport(screenshotFile);
                }
                extentReport.AddTestLog(Status.Info, "Closing all Browsers");

            }
            catch (Exception ex)
            {
                extentReport.AddTestLog(Status.Error, ex.StackTrace);
            }
            finally
            {
                cmnDriver.CloseAllBrowsers();

            }
        }
    }

    
}
