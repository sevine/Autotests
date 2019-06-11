using Autotests.PageModel.BaseElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autotests.PageModel
{
    public class EpisodesPage : AnyPage
    {
        public EpisodesPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        private const string lblRecentlyAdded = "//h2[text()='Recently Added']";

        public bool IsEpisodesPageOpened() => WaitForElementPresent(By.XPath(lblRecentlyAdded)) != null;

        public new EpisodesPage WaitForPageLoaded()
        {
            base.WaitForPageLoaded();
            return this;
        }
    }
}
