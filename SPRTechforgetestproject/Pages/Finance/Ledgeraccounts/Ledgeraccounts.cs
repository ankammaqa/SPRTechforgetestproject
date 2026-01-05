using OpenQA.Selenium;
using SPRTechforgetestproject.Common.Drivers;
using SPRTechforgetestproject.Utilitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPRTechforgetestproject.Pages.Finance.Ledgeraccounts
{
    public class Ledgeraccounts:Basepage
    {
        public Ledgeraccounts() : base(Driverclass.GetDriver())
        {

        }
        private By LedgerAccounts =By.XPath("//a[.//span[normalize-space()='Ledger Accounts']]");
        private By NewAccount => By.XPath("//button[text()='+ Add Account']");


        // -------- ACCOUNT CREATION --------
        private By accountNameInput = By.XPath("//input[@placeholder='e.g. Axis Bank, Office Rent']");
        private By accountTypeDropdown = By.XPath("//label[text()='Account Type']/following::select[1]");
        private By subLedgerInput = By.XPath("//input[@placeholder='e.g. Utilities, Employee, HDFC']");
        private By openingBalanceInput = By.XPath("(//input[@type='number'])[1]");
        private By fixedAmountInput = By.XPath("(//input[@type='number'])[2]");
        private By startDateInput = By.XPath("//input[@type='date']");
        private By accountDescriptionInput = By.XPath("//label[text()='Description']/following::input[1]");
        private By saveAccountBtn = By.XPath("//button[text()='Save Account']");

        public void ClickLedgerAccounts()
        {
            ScrollToElement(LedgerAccounts, 10);
            JsClick(LedgerAccounts, 10);


        }
        public void ClickNewAccount()
        {
            Click(NewAccount,10);

        }
        public void FillAccountDetails(string name, string accountType, string sub,
           string opening, string fixedAmt, string startDate, string description)
        {
            EnterText(accountNameInput, name, 10);
            SelectByText(accountTypeDropdown, accountType, 30);

            if (sub != "NA")
                EnterText(subLedgerInput, sub, 10);

            EnterText(openingBalanceInput, opening, 10);

            if (accountType == "Expense" || accountType == "Salary")
            {
                // Scroll to Fixed Amount field
                ScrollToElement(fixedAmountInput, 20);
                EnterText(fixedAmountInput, fixedAmt, 10);

                // Scroll to Start Date field
                ScrollToElement(startDateInput, 20);
                EnterText(startDateInput, startDate, 10);
            }

            EnterText(accountDescriptionInput, description, 10);
        }

        public void ClickSaveAccount()
        {
            Click(saveAccountBtn, 10);
        }

    }
}
