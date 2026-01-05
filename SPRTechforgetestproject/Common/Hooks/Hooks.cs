using Reqnroll;
using SPRTechforgetestproject.Common.Drivers;

namespace SPRTechforgetestproject.Common.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            Driverclass.InitBrowser();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driverclass.CloseBrowser();
        }
    }
}