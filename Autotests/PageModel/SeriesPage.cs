using Autotests.PageModel.BaseElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Autotests.PageModel
{
    public class SeriesPage : BasePage
    {
        public SeriesPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        #region locators
        private const string btnAddToFavorites = ".show-header__menu a[aria-label]";
        private const string lnkCast = "[href *= '/credits/cast']";
        #endregion

        #region AssertMethods
        public bool IsSeriesPageOpened(string SeriesPageTitle) => _driver.FindElements(By.XPath("//div[@class = 'slideshow__title'][text()='" + SeriesPageTitle + "']")).Count > 0;
        #endregion

        #region ClickMethods
        public SeriesPage ClickAddToFavorites()
        {
            Thread.Sleep(3000);
            _driver.FindElement(By.CssSelector(btnAddToFavorites)).Click();
            return this;
        }

        public CastPage GoToCastPage()
        {
            _driver.FindElement(By.CssSelector(lnkCast)).Click();
            Thread.Sleep(3000);
            return new CastPage(_driver);
        }
        #endregion
    }
}