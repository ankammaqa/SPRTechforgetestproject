using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SPRTechforgetestproject.Common.Drivers;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SPRTechforgetestproject.Pages.Administration
{
    public class Administrationpage
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        public Administrationpage()
        {
            driver = Driverclass.GetDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

       

        public void ClickAdministration()
        {
          
         wait.Until(d =>d.FindElement(By.XPath("//span[normalize-space()='Administration']"))).Click();

        }
        public void ClickUserManagement()
        {
          wait.Until(d=> d.FindElement(By.XPath("//a[normalize-space()='User Management']"))).Click();

        }
        public void ClickAdduser()
        {
            wait.Until(d => d.FindElement(By.XPath("//button[text()='+ Add User']"))).Click();

        }
        public void UserFillwithAdministrationDetails(
     string name,
     string email,
     string role,
     string accessModule)
        {
            // Full Name
            wait.Until(d => d.FindElement(
                By.XPath("//input[@placeholder='e.g. Thirumal Reddy']")
            )).SendKeys(name);

           IWebElement emailinput= wait.Until(d =>
     d.FindElement(By.XPath(
         "//label[normalize-space()='Auto-Generated Login ID']/following::input[1]")));
            emailinput.Clear();
            Thread.Sleep(5000); // Small delay to ensure the field is cleared
            emailinput.SendKeys(email);
            // Default Password (READ ONLY)
            string defaultPassword = wait.Until(d => d.FindElement(
                By.XPath("//label[normalize-space()='Default Password']/following-sibling::div")
            )).Text;

            Console.WriteLine("Default Password: " + defaultPassword);

            // Role dropdown
            IWebElement roleDropdown = wait.Until(d =>
                d.FindElement(By.XPath("//select[@required]"))
            );

            SelectElement roledrop = new SelectElement(roleDropdown);
            roledrop.SelectByText(role);

            // Access Modules checkbox (dynamic)
            IWebElement accessCheckbox = wait.Until(d =>
                d.FindElement(By.XPath(
                    "//label[normalize-space()='Access Modules']/following-sibling::div" +
                    "//label[contains(normalize-space(),'" + accessModule + "')]/input"
                )));
            
            if (!accessCheckbox.Selected)
            {
                accessCheckbox.Click();
            }
        }

        public void SaveuserSuccessfully()
        {
            IWebElement savebutton = wait.Until(d => d.FindElement(By.XPath("//button[@type='submit' and normalize-space()='Save User']")));
            savebutton.Click();
            Thread.Sleep(2000); // Wait for 2 seconds to ensure the user is saved
        }


    }
}
