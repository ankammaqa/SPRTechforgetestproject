using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPRTechforgetestproject.Common.Drivers;

namespace SPRTechforgetestproject.Runsettings
{
    public class Loginpage
    {


        private IWebDriver driver;

        public Loginpage()
        {
            driver = Driverclass.GetDriver();
        }

        public void OpenUrl()
        {
            driver.Navigate().GoToUrl("https://sprtechforge.com/");
            Thread.Sleep(2000);
        }

        private IWebElement LoginBtn => driver.FindElement(By.XPath("//button[text()='Login']"));
        private IWebElement Username => driver.FindElement(By.XPath("//input[@placeholder='e.g. name@sprtechforge.com']"));
        private IWebElement Password => driver.FindElement(By.XPath("//input[@placeholder='Enter password']"));
        private IWebElement SubmitLogin => driver.FindElement(By.XPath("//button[text()='Login']"));

        public void Login()
        {
            LoginBtn.Click();
            Thread.Sleep(2000);

            Username.SendKeys("thirumalreddy@sprtechforge.com");
            Password.SendKeys("Shooter@2026");

            SubmitLogin.Click();
            Thread.Sleep(2000);
        }
    }

}
