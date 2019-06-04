using Autotests.PageModel.BaseElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autotests.PageModel
{
    class EpisodesPage : BasePage
    {
        public EpisodesPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        private const string lblRecentlyAdded = "//h2[text()='Recently Added']";

        public bool IsEpisodesPageOpened() => _driver.FindElement(By.XPath(lblRecentlyAdded)).Displayed;
    }
}
