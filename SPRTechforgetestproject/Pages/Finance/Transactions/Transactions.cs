using OpenQA.Selenium;
using Reqnroll;
using SPRTechforgetestproject.Common.Drivers;
using SPRTechforgetestproject.Utilitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPRTechforgetestproject.Pages.Finance.Transactions
{
    public class Transactions:Basepage
    {
        
        public Transactions() : base(Driverclass.GetDriver())
        {
        }

        private By Transaction =By.XPath("//span[text()='Transactions']");

        private By NewEntry =By.XPath("//button[text()='+ New Entry']");


        // -------- VALIDATION / SEARCH --------
        private By accountSearchInput = By.XPath("//input[@placeholder='Search accounts by name or sub-type...']");
        private By transactionSearchInput = By.XPath("//input[@placeholder='Search description...']");
        private By transactionTypeDropdown = By.XPath("(//select[contains(@class,'border-spr-700')])[1]");
        private By transactionStatusDropdown = By.XPath("(//select[contains(@class,'border-spr-700')])[2]");
        private By sourceFromDropdown = By.XPath("(//select[contains(@class,'border-spr-700')])[3]");
        private By destinationToDropdown = By.XPath("(//select[contains(@class,'border-spr-700')])[4]");
        private By fromDateFilter = By.XPath("(//input[@type='date' and contains(@class,'border-spr-700')])[1]");
        private By toDateFilter = By.XPath("(//input[@type='date' and contains(@class,'border-spr-700')])[2]");

        // -------- DYNAMIC TABLE --------
        private By accountRow(string accName) => By.XPath($"//table//td[contains(text(),'{accName}')]");

        // ================= ACTION METHODS =================


        public void Gototransactions()
        {
           Click(Transaction,10);
        }

        public void Gotonewentry()
        {
            Click(NewEntry,10);
        }

        public void ValidateAccountCreation()
        {
            string accName = ScenarioContext.Current["AccountName"].ToString();
            Click(accountRow(accName), 30);
        }

        public void ValidateTransactionCreation(
            string Description, string Types, string Statuses,
            string SourceFrom, string DestinationTo, string Fromdate, string Todate)
        {
            EnterText(transactionSearchInput, Description, 10);
            SelectByText(transactionTypeDropdown, Types, 30);
            SelectByText(transactionStatusDropdown, Statuses, 30);
            SelectByText(sourceFromDropdown, SourceFrom, 30);
            SelectByText(destinationToDropdown, DestinationTo, 30);
            EnterText(fromDateFilter, Fromdate, 10);
            EnterText(toDateFilter, Todate, 10);
        }

        public void SearchByNameOrSubType(string searchBy)
        {
            EnterText(accountSearchInput, searchBy, 10);
        }

       
       
    }
}
