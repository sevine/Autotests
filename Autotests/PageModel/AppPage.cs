using Autotests.PageModel.BaseElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autotests.PageModel
{
    class AppPage : BasePage
    {
        public AppPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        private const string lblRecentlyAdded = "//h1[text()= 'The NBC App']";

        public bool IsAppPageOpened() => _driver.FindElement(By.XPath(lblRecentlyAdded)).Displayed;
    }
}
