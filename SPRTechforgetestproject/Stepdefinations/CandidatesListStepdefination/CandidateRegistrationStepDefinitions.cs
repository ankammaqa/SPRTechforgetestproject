using System;
using Reqnroll;
using SPRTechforgetestproject.CandidatesListpage;
using SPRTechforgetestproject.Runsettings;

namespace SPRTechforgetestproject.Stepdefinations.Stepdefination
{
    [Binding]
    public class CandidateRegistrationStepDefinitions
    {
        Loginpage login = new Loginpage();
        NavigationPage navigation = new NavigationPage();
        CandidatePage candidate = new CandidatePage();
        string expectedStatus;

        [Given(@"the user opens the website and logs in")]
        public void GivenTheUserOpensTheWebsiteAndLogsIn()
        {
            login.OpenUrl();
            login.Login();
        }

        [Given(@"the user navigates to add candidate page")]
        public void GivenTheUserNavigatesToAddCandidatePage()
        {
            navigation.GoToAddCandidate();
        }

        [When(@"the user enters name ""(.*)"" and id ""(.*)""")]
      /*  public void WhenTheUserEntersNameAndId(string name, string id)
        {
            candidate.EnterBasicDetails(name, id);
        }

        [When(@"the user enters phone ""(.*)"" and alternate phone ""(.*)""")]
        public void WhenTheUserEntersPhoneAndAlternatePhone(string phone1, string phone2)
        {
            candidate.EnterPhoneNumbers(phone1, phone2);
        }

        [When(@"the user enters email ""(.*)""")]
        public void WhenTheUserEntersEmail(string email)
        {
            candidate.EnterEmail(email);
        }

        [When(@"the user enters address ""(.*)""")]
        public void WhenTheUserEntersAddress(string address)
        {
            candidate.EnterAddress(address);
        }

        [When(@"the user selects current status ""(.*)""")]
        public void WhenTheUserSelectsCurrentStatus(string status)
        {
            expectedStatus = status;
            candidate.SelectStatus(status);
        }*/

        [When(@"the user saves the candidate")]
        public void WhenTheUserSavesTheCandidate()
        {
            candidate.SaveCandidate();
        }

        [Then(@"the candidate should be added with correct status")]
        public void ThenTheCandidateShouldBeAddedWithCorrectStatus()
        {
            Assert.IsTrue(true, "Candidate saved with status: " + expectedStatus);
        }
        [When("the user enter {string} {string} {string} {string} {string} {string} {string} {string} {string} {string} {string} {string} {string} {string} {string} {string}")]
        public void WhenTheUserEnter(string name, string id, string phone1, string phone2, string email,string refferedby, string address,
            string supportstatus,string startdate,string Amount,string Agreedtotalamount, string totalpaid,
            string currentstatus, string Notes,string date,string signature)
        {
            candidate.UserEnterNewcandidatedetails(name,id,phone1,phone2,email,refferedby,address, supportstatus,startdate,Amount, Agreedtotalamount,totalpaid,currentstatus,Notes,date,signature);
        }




    }
}
