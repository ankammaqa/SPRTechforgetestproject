using System;
using Reqnroll;
using SPRTechforgetestproject.Pages.Administration;
using SPRTechforgetestproject.Runsettings;

namespace SPRTechforgetestproject.Stepdefinations.Administrationstepdefination
{
    [Binding]
    public class AdministrationStepDefinitions
    {
        Loginpage loginpage = new Loginpage();
        Administrationpage newadministrationpage = new Administrationpage();

        [Given("user navigate to logs page")]
        public void GivenUserNavigateToLogsPage()
        {
            loginpage.OpenUrl();
            loginpage.Login();
        }

        [When("user click on Administration")]
        public void WhenUserClickOnAdministration()
        {
           
            
            newadministrationpage.ClickAdministration();
        }

        [When("user click on User Management")]
        public void WhenUserClickOnUserManagement()
        {
           newadministrationpage.ClickUserManagement();
        }

        [When("user click on Adduser")]
        public void WhenUserClickOnAdduser()
        {
           newadministrationpage.ClickAdduser();
        }

        [When("user fill with details {string} {string} {string} {string}")]
        public void WhenUserFillWithDetails(string name, string email, string role, string Accesmodule)
        {
           newadministrationpage.UserFillwithAdministrationDetails(name, email, role, Accesmodule);
        }

        [Then("user should be added saveuser successfully")]
        public void ThenUserShouldBeAddedSaveuserSuccessfully()
        {
           newadministrationpage.SaveuserSuccessfully();
        }
    }
}
