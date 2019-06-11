using Autotests.PageModel.BaseElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autotests.PageModel
{
    public class AppPage : AnyPage
    {
        public AppPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        private const string lblRecentlyAdded = "//h1[text()= 'The NBC App']";

        public bool IsAppPageOpened() => WaitForElementPresent(By.XPath(lblRecentlyAdded)) != null;

        public new AppPage WaitForPageLoaded()
        {
            base.WaitForPageLoaded();
            return this;
        }
    }
}
