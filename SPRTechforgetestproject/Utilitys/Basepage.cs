using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SPRTechforgetestproject.Utilitys
{
    public class Basepage
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        public Basepage(IWebDriver driver)
        {
            this.driver = driver;
        }
        protected WebDriverWait GetWait(int seconds)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
        }

        protected IWebElement WaitForElement(By locator, int seconds = 20)
        {
            return GetWait(seconds).Until(d => d.FindElement(locator));
        }

        // ✅ MUST be protected
        protected void EnterText(By locator, string value, int seconds = 20)
        {
            var element = WaitForElement(locator, seconds);
            element.Clear();
            element.SendKeys(value);
        }

        // ✅ MUST be protected
        protected void SelectByText(By locator, string text, int seconds = 20)
        {
            var element = WaitForElement(locator, seconds);
            new SelectElement(element).SelectByText(text);
        }

        /*protected void Click(By locator, int seconds = 20)
        {
            WaitForElement(locator, seconds).Click();
        }*/
        protected void Click(By locator, int seconds = 20)
        {
            var element = GetWait(seconds).Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator)
            );
            element.Click();
        }

        protected void ScrollToElement(By locator, int seconds = 20)
        {
            var element = WaitForElement(locator, seconds);
            ((IJavaScriptExecutor)driver)
                .ExecuteScript("arguments[0].scrollIntoView({behavior:'smooth', block:'center'});", element);
        }

        // Scroll by pixels
        protected void ScrollBy(int x, int y)
        {
            ((IJavaScriptExecutor)driver)
                .ExecuteScript($"window.scrollBy({x},{y});");
        }

        // Scroll to bottom of page
        protected void ScrollToBottom()
        {
            ((IJavaScriptExecutor)driver)
                .ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
        }

        // Scroll to top of page
        protected void ScrollToTop()
        {
            ((IJavaScriptExecutor)driver)
                .ExecuteScript("window.scrollTo(0, 0);");
        }

        // Mouse wheel scroll (when needed)
        protected void MouseScroll(int deltaY)
        {
            new Actions(driver)
                .ScrollByAmount(0, deltaY)
                .Perform();
        }
        protected void JsClick(By locator, int seconds = 20)
        {
            var element = WaitForElement(locator, seconds);
            ((IJavaScriptExecutor)driver)
                .ExecuteScript("arguments[0].click();", element);
        }
    }
}
