using Autotests.PageModel.BaseElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autotests.PageModel
{
    class SearchPage : BasePage
    {
        public SearchPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        private const string txtSearch = ".search-input__input";

        public bool IsSearchPageOpened() => _driver.FindElement(By.CssSelector(txtSearch)).Displayed;
    }
}
