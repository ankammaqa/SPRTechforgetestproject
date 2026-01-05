using OpenQA.Selenium;
using SPRTechforgetestproject.Common.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPRTechforgetestproject.CandidatesListpage
{
    public class NavigationPage
    {
        private IWebDriver driver;

        public NavigationPage()
        {
            driver = Driverclass.GetDriver();
        }

        private IWebElement Candidates => driver.FindElement(By.XPath("//span[text()='Candidates']"));
        private IWebElement CandidateList => driver.FindElement(By.XPath("//span[text()='Candidate List']"));
        private IWebElement AddCandidateBtn => driver.FindElement(By.XPath("//button[text()='+ Add Candidate']"));

        public void GoToAddCandidate()
        {
            Candidates.Click();
            Thread.Sleep(2000);

            CandidateList.Click();
            Thread.Sleep(2000);

            AddCandidateBtn.Click();
            Thread.Sleep(2000);
            
        }
    }
}
