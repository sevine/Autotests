using Autotests.PageModel.BaseElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Autotests.PageModel
{
    public class CastPage : AnyPage
    {
        public CastPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        #region locators
        private const string lstActorsCount = ".shelf__tiles > a";
        #endregion 

        #region DoMethods
        public int GetActorsCount() => _driver.FindElements(By.CssSelector(lstActorsCount)).Count;

        public ActorPage GoToActorPage(string actor)
        {
            _driver.FindElement(By.XPath($"//*[text()='{actor}']/../../../../div/img")).Click();
            return new ActorPage(_driver);
        }

        public new CastPage WaitForPageLoaded()
        {
            base.WaitForPageLoaded();
            return this;
        }
        #endregion

        #region AssertMethods
        public bool IsActorDisplayed(string actor) => _driver.FindElements(By.XPath($"//*[@class='tile__description']//*[contains(text(), '{actor}')]")).Count > 0;
        #endregion
    }
}