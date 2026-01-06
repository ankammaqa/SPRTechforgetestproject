using Reqnroll;
using SPRTechforgetestproject.Pages.Finance.Financenavigation;
using SPRTechforgetestproject.Pages.Finance.Ledgeraccounts;
using SPRTechforgetestproject.Pages.Finance.payroll;
using SPRTechforgetestproject.Pages.Finance.Transactions;
using SPRTechforgetestproject.Runsettings;
using System;

namespace SPRTechforgetestproject.Stepdefinations.FinanceStepdefination
{
    [Binding]
    public class FeaturefileofchatgptStepDefinitions
    {
        Loginpage login = new Loginpage();
        Transactions transactions = new Transactions();
        Ledgeraccounts ledgeraccounts = new Ledgeraccounts();
        payroll payroll = new payroll();
        FinanceNavigation nav = new FinanceNavigation();
      

        [Given("user navigate to login page")]
        public void GivenUserNavigateToLoginPage()
        {
            login.OpenUrl();
            login.Login();
        }


        [When("user clicks Finance module")]
        public void WhenUserClicksFinanceModule()
        {
            nav.GoToFinancemodule();
        }
        [When("user click on Transactions")]
        public void WhenUserClickOnTransactions()
        {
            transactions.Gototransactions();
        }
        [When("user click on Payroll")]
        public void WhenUserClickOnPayroll()
        {
            payroll.Gotopayroll();
        }

        [When("user clicks payexpance module")]
        public void WhenUserClicksPayexpanceModule()
        {
            payroll.GotopayExpance();
        }

/*
        [When("user clicks NewEntry")]
        public void WhenUserClicksNewEntry()
        {
            transactions.Gotonewentry();
        }*/

        //Ledger account details
        [When("user click on Legder Accounts")]
        public void WhenUserClickOnLegderAccounts()
        {
            ledgeraccounts.ClickLedgerAccounts();
        }


        [When("user click Add Account")]
        public void WhenUserClickAddAccount()
        {
            ledgeraccounts.ClickNewAccount();
        }


        [When("user selects (.*) page")]
        public void WhenUserSelectsModule(string module)
        {
            payroll.ClickModule(module);
        }
        [When("user fills details with {string} {string} {string} {string} {string}")]
        public void WhenUserFillsDetailsWith(
            string date,
            string amount,
            string from,
            string to,
            string description)
        {
            payroll.FillDetails(date, amount, from, to, description);

        }



       

        [Then("record should be saved successfully")]
        public void ThenRecordSaved()
        {
            payroll.SaveRecord();
        }

       
       


        [When(@"user fills details with ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void WhenUserFillsDetailsWith(
    string accountName,
    string accountType,
    string subLedger,
    string openingBalance,
    string fixedMonthlyAmount,
    string startDate,
    string description)
        {
            ScenarioContext.Current["AccountName"] = accountName;

            ledgeraccounts.FillAccountDetails(
                accountName,
                accountType,
                subLedger,
                openingBalance,
                fixedMonthlyAmount,
                startDate,
                description
            );
        }
            [When("user click on save account")]
        public void WhenUserClickOnSaveAccount()
        {
            ledgeraccounts.ClickSaveAccount();
        }

        [Then("Accounts added succesfully")]
        public void ThenAccountsAddedSuccesfully()
        {
            transactions.ValidateAccountCreation();
        }
        [When(@"user fill details with ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void WhenUserFillDetailsWith(string Description, string Types, string Statuses, string SourceFrom, string DestinationTo, string Fromdate, string Todate)
        {
            transactions.ValidateTransactionCreation(Description, Types, Statuses, SourceFrom, DestinationTo, Fromdate, Todate);
        }

        [Then("user search by name or sub-type {string}")]
        public void ThenUserSearchByNameOrSub_Type(string Searchby)
        {
           transactions.SearchByNameOrSubType(Searchby);
        }
    }
}
