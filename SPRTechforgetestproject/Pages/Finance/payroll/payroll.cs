using OpenQA.Selenium;
using SPRTechforgetestproject.Common.Drivers;
using SPRTechforgetestproject.Utilitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPRTechforgetestproject.Pages.Finance.payroll
{
    public class payroll : Basepage
    {
        public payroll() : base(Driverclass.GetDriver())
        {

        }
        private By payrollclick =By.XPath("//span[text()='Payroll']");

        private By payexpance =By.XPath("//button[text()='+ Pay Expense']");


        // -------- MODULE --------
        private By moduleButton(string module) => By.XPath($"//button[text()='{module}']");

        // -------- TRANSACTION ENTRY --------
        private By dateInput = By.XPath("//input[@type='date' and @required]");
        private By amountInput = By.XPath("//input[@type='number']");
        private By fromDropdown = By.XPath("(//select[contains(@class,'rounded-lg')])[1]");
        private By toDropdown = By.XPath("(//select[contains(@class,'rounded-lg')])[2]");
        private By descriptionInput = By.XPath("//input[contains(@placeholder,'e.g.')]");
        private By saveRecordBtn = By.XPath("//button[text()='Save Record']");




        public void Gotopayroll()
        {
            Click(payrollclick,10);
        }

        public void GotopayExpance()
        {
            Click(payexpance,10);
        }
        public void ClickModule(string module)
        {
            Click(moduleButton(module), 10);
        }

        public void FillDetails(string date, string amount, string from, string to, string description)
        {
            EnterText(dateInput, date, 10);
            EnterText(amountInput, amount, 10);
            SelectByText(fromDropdown, from, 30);
            SelectByText(toDropdown, to, 30);
            EnterText(descriptionInput, description, 10);
        }

        public void SaveRecord()
        {
            Click(saveRecordBtn, 10);
        }
    }
}
