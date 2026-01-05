using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Reqnroll;
using SPRTechforgetestproject.CandidatesListpage;
using SPRTechforgetestproject.Common.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPRTechforgetestproject.Pages.Training_placements
{
    public class Trainingandplacements
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        public Trainingandplacements() {
            driver = Driverclass.GetDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        }
        private IWebElement Trainin_placements => driver.FindElement(By.XPath("//span[text()='Training & Placement']"));

        private IWebElement interviewandresumes => driver.FindElement(By.XPath("//a[normalize-space()='Interviews & Resumes']"));
        public void ClickTrainingandplacements()
        {
            Thread.Sleep(1000);
            Trainin_placements.Click();
        }
        public void clickinterviewandResumes()
        {
            Thread.Sleep(1000);
            interviewandresumes.Click();
        }
        
        public void UploadsResume(string candidateName)
        {
            wait.Until(d =>d.FindElement(By.XPath(
                $"//td[normalize-space()='{candidateName}']/ancestor::tr//input[@type='file']")))
                .SendKeys(@"D:\MyData\Resume.docx");
        }

        public void ClicksBookInterview(string candidateName)
        {
            wait.Until(d =>d.FindElement(By.XPath(
                $"//td[normalize-space()='{candidateName}']/ancestor::tr//button[normalize-space()='Book Interview']")))
                .Click();


        }
       
        public void UserFillWithDetails(string date, string time, string companyname, string type, string round, string supportperson)
        {
            wait.Until(d => d.FindElement(By.XPath("//input[@type='date']"))).SendKeys(date);
            wait.Until(d => d.FindElement(By.XPath("//input[@type='time']"))).SendKeys(time);
            wait.Until(d => d.FindElement(By.XPath("//label[text()='Company Name']/following::input[1]"))).
                SendKeys(companyname);
            IWebElement dropdown = driver.FindElement(By.XPath("//label[text()='Type']/following::select[1]"));
            SelectElement typeSelect = new SelectElement(dropdown);
            typeSelect.SelectByText(type);
            Thread.Sleep(2000); // Wait for 1 second to ensure dropdown selection is processed
            wait.Until(d => d.FindElement(By.XPath("//input[@placeholder='e.g. L1, Managerial']"))).
                SendKeys(round);
            wait.Until(d => d.FindElement(By.XPath("//label[text()='Support Person (if any)']/following::input[1]"))).SendKeys(supportperson);
            Thread.Sleep(2000); // Wait for 2 seconds to ensure all fields are filled
        }

        public void BookedSuccessfully()
        {
            ;

            wait.Until(d =>
                d.FindElement(By.XPath("//button[@type='submit']"))).Click();
            Thread.Sleep(2000); // Wait for 2 seconds to ensure submission is processed

        }

    }
}
