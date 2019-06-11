using Autotests.PageModel.BaseElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Autotests.PageModel
{
    public class ActorPage : AnyPage
    {
        public ActorPage (IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        #region Locators
        private const string btnMore = ".bio__long-desc__more";
        private const string btnLess = ".bio__long-desc__more--active";
        #endregion
        
        #region DoMethods
        public ActorPage ClickMore()
        {
            WaitForElementPresent(By.CssSelector(btnMore)).Click();
            return WaitForPageLoaded();
        }

        public ActorPage WaitForPageLoaded()
        {
            return this;
        }
        #endregion

        #region AssertMethods
        public bool IsLessBtnDisplayed() => _driver.FindElements(By.CssSelector(btnLess)).Count > 0;
        #endregion
    }
}