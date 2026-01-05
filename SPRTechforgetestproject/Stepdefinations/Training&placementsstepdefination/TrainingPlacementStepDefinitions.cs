using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Reqnroll;
using SPRTechforgetestproject.CandidatesListpage;
using SPRTechforgetestproject.Pages.Finance;
using SPRTechforgetestproject.Pages.Training_placements;
using SPRTechforgetestproject.Runsettings;
using System;

namespace SPRTechforgetestproject
{
    [Binding]


    public class TrainingPlacementStepDefinitions
    {
        Loginpage login = new Loginpage();
        Trainingandplacements newtrainingplacements = new Trainingandplacements();
        [Given("user navigate to log page")]
        public void GivenUserNavigateToLogPage()
        {
           login.OpenUrl();
            login.Login();
        }


        [When("user click on Training&placement")]
        public void WhenUserClickOnTrainingPlacement()
        {
            newtrainingplacements.ClickTrainingandplacements();
        }


        [When("user clicks Interview&Resumes")]
        public void WhenUserClicksInterviewResumes()
        {
            newtrainingplacements.clickinterviewandResumes();
        }

        [When("the user uploads resume for {string}")]
        public void WhenTheUserUploadsResumeFor(string candidatename)
        {
            newtrainingplacements.UploadsResume(candidatename);
        }

        [When("the user clicks book interview for {string}")]
        public void WhenTheUserClicksBookInterviewFor(string candidatename)
        {
            newtrainingplacements.ClicksBookInterview(candidatename);
        }
        [When("user fill with details {string} {string} {string} {string} {string} {string}")]
        public void WhenUserFillWithDetails(string date, string time, string companyname, string type, string round, string supportperson)
        {
            newtrainingplacements.UserFillWithDetails( date, time, companyname, type, round, supportperson);
        }

        [Then("interview should be booked successfully for")]
        public void ThenInterviewShouldBeBookedSuccessfullyFor()
        {
            newtrainingplacements.BookedSuccessfully();

        }
    }
}
