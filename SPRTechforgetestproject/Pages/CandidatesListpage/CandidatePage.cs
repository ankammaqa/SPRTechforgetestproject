using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SPRTechforgetestproject.Common.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPRTechforgetestproject.CandidatesListpage
{
    public class CandidatePage
    {
        private IWebDriver driver;
        private IJavaScriptExecutor js;
        private WebDriverWait wait;

        public CandidatePage()
        {
            driver = Driverclass.GetDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            js = (IJavaScriptExecutor)driver;

        }
        public void SaveCandidate()
        {
            wait.Until(d => d.FindElement(By.XPath("//button[text()='Save Candidate']"))).Click();
            js.ExecuteScript("window.scrollBy(0,2000);");
            Thread.Sleep(2000);
        }
        private IWebElement WaitForElement(By locator)
        {
            return wait.Until(d => d.FindElement(locator)); // Now uses WebDriverWait's Until
        }

        private void SelectByText(By locator, string text)
        {
            var element = WaitForElement(locator);
            new SelectElement(element).SelectByText(text);
        }
        private void SelectByvalue(By locator, string text)
        {
            var element = WaitForElement(locator);
            new SelectElement(element).SelectByValue(text);
        }

        private void EnterText(By locator, string value)
        {
            var element = WaitForElement(locator);
            element.Clear();
            element.SendKeys(value);
        }
        public void UserEnterNewcandidatedetails(string name, string id, string phone1, 
            string phone2, string email, string refferedby,string address,string supportstatus,
            string startdate,string Amount,string totalamount, string amountpaid, string currentstatus,
            string Notes,string date,string signature)
        {


            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            
            EnterText(
                   By.XPath("(//input[@required])[1]"), name);
            EnterText(
              By.XPath("(//input[@required])[2]"), id);
            EnterText(
                By.XPath("(//input[@placeholder='Digits only'])[1]"), phone1);
            EnterText(
              By.XPath("(//input[@placeholder='Digits only'])[2]"), phone2);
            js.ExecuteScript("window.scrollBy(0,1000);");

            EnterText(
                By.XPath("//input[@type='email']"), email);

            EnterText(
                By.XPath("//textarea[@placeholder='Enter full address']"), address);

            EnterText(
                By.XPath("//input[@placeholder='Name of referrer (Optional)']"), refferedby);

            SelectByText(
               By.XPath("//label[text()='Support Status']/following::select[1]"), supportstatus);
            if (supportstatus.Equals("Active Support (Monthly Billing)"))
            {

                wait.Until(d => d.FindElement(By.XPath("//input[@type='date']"))).SendKeys(startdate);


                // AMOUNT
                wait.Until(d => d.FindElement(By.XPath("//label[text()='Monthly Amount (₹)']/following::input[1]"))).SendKeys(Amount);
            }
     
            EnterText(
                By.XPath("//label[text()='Agreed Total Amount (₹)']/following::input[1]"), totalamount);

            EnterText(
                By.XPath("//label[text()='Total Paid (₹)']/following::input[1]"), amountpaid);
            SelectByvalue(
               By.XPath("//label[text()='Current Status']/following::select[1]"), currentstatus);
            EnterText(
              By.XPath("//textarea[@rows='2']"), Notes);

            IWebElement agreementTextArea = wait.Until(d =>
         d.FindElement(By.XPath("//textarea[@rows='8']")));

            // Scroll to textarea
            js.ExecuteScript("arguments[0].scrollIntoView({block:'center'});", agreementTextArea);

            // Get existing agreement text
            string agreementText = agreementTextArea.GetAttribute("value");

            // Replace Date
            agreementText = agreementText.Replace(
                "Date: _________________",
                $"Date: {date}");

            // Replace Signature
            agreementText = agreementText.Replace(
                "Signature: _________________",
                $"Signature: {signature}");

            // Clear old content and enter updated content
            agreementTextArea.Clear();
            agreementTextArea.SendKeys(agreementText);

        }
    }
}
