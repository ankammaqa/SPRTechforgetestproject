using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
{
    
}

namespace SPRTechforgetestproject.Common.Drivers
{
    public class Driverclass
    {
        public static IWebDriver driver;

        public static void InitBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        public static IWebDriver GetDriver()
        {
            return driver;
        }

        public static void CloseBrowser()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}
