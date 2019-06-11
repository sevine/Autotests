using Autotests.PageModel.BaseElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autotests.PageModel
{
    public class SearchPage : AnyPage
    {
        public SearchPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        private const string txtSearch = ".search-input__input";

        public bool IsSearchPageOpened() => WaitForElementPresent(By.CssSelector(txtSearch)) != null;

        public new SearchPage WaitForPageLoaded()
        {
            base.WaitForPageLoaded();
            return this;
        }
    }
}
