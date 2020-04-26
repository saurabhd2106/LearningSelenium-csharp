using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibs.Contracts;
using OpenQA.Selenium;

namespace CommonLibs.Implementations
{
    class ScreenshotControl : IScreenshot
    {
        ITakesScreenshot camera;

        public ScreenshotControl(IWebDriver driver)
        {
            camera = (ITakesScreenshot)driver;
        }
        public void CaptureAndSaveScreenshot(string Filename)
        {
            _ = Filename.Trim();

            if(File.Exists(Filename))
            {
                throw new Exception("File already exist.."+ Filename);
            }

           Screenshot screenshot = camera.GetScreenshot();

            screenshot.SaveAsFile(Filename);

        }
    }
}
