using Autotests.PageModel.BaseElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Autotests.PageModel
{
    public class CastPage : BasePage
    {
        public CastPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        #region locators
        private const string lblRecentlyAdded = "//h1[text()= 'The NBC App']";
        private const string lstActorsCoun = ".shelf__tiles > a";
        private const string lnkActorPage = ".shelf__tiles > a";
        #endregion 

        #region DoMethods
        public int GetActorsCount()
        {
            Thread.Sleep(4000);
            return _driver.FindElements(By.CssSelector(lstActorsCoun)).Count;
        }

        public ActorPage GoToActorPage(string actor)
        {
            _driver.FindElement(By.XPath($"//*[text()='{actor}']/../../../../div/img")).Click();
            Thread.Sleep(2000);
            return new ActorPage(_driver);
        }
        #endregion

        #region AssertMethods
        public bool IsActorDisplayed(string actor) => _driver.FindElements(By.XPath($"//*[@class='tile__description']//*[contains(text(), '{actor}')]")).Count > 0;
        #endregion

    }
}