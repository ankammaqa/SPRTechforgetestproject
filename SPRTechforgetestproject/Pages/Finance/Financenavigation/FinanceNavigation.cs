using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V141.PWA;
using OpenQA.Selenium.Support.UI;
using SPRTechforgetestproject.Common.Drivers;
using SPRTechforgetestproject.Utilitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPRTechforgetestproject.Pages.Finance.Financenavigation
{
    public class FinanceNavigation:Basepage
    {
       
        public FinanceNavigation():base(Driverclass.GetDriver())
        {
        }

        private By FinanceModule => By.XPath("//span[text()='Finance']");
       
        public void GoToFinancemodule()
        {
            Click(FinanceModule,10);
           

        }
    }
}
