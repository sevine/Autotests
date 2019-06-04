using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Autotests.PageModel.BaseElements;

namespace Autotests.PageModel
{
    public class ShowsPage : BasePage
    {
        public ShowsPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        #region locators
        private const string lnkAllTab = "a[href='/shows/all']";
        private const string lnkCurrentTab = "a[href='/shows/current']";
        private const string lnkUpcomingTab = "a[href='/shows/upcoming']";
        private const string lnkThrowbackTab = "a[href='/shows/classic-throwback']";

        private const string lblAllTab = ".tabs__content__list:nth-of-type(1) h2";
        private const string lblCurrentTab = ".tabs__content__list:nth-of-type(2) h2";
        private const string lblUpcomingTab = ".tabs__content__list:nth-of-type(3) h2";
        private const string lblThrowbackTab = ".tabs__content__list:nth-of-type(4) h2";
        #endregion

        #region ClickMethods
        public ShowsPage ClickOnAllTab()
        {
            _driver.FindElement(By.CssSelector(lnkAllTab)).Click();
            Thread.Sleep(2 * 1000);
            return this;
        }

        public ShowsPage ClickOnCurrentTab()
        {
            _driver.FindElement(By.CssSelector(lnkCurrentTab)).Click();
            Thread.Sleep(2 * 1000);
            return this;
        }

        public ShowsPage ClickOnUpcomingTab()
        {
            _driver.FindElement(By.CssSelector(lnkUpcomingTab)).Click();
            Thread.Sleep(2 * 1000);
            return this;
        }

        public ShowsPage ClickOnThrowbackTab()
        {
            _driver.FindElement(By.CssSelector(lnkThrowbackTab)).Click();
            Thread.Sleep(2 * 1000);
            return this;
        }
        #endregion

        #region AssertMethods
        public bool IsAllTabDisplayed() => _driver.FindElement(By.CssSelector(lblAllTab)).Displayed;

        public bool IsCurrentTabDisplayed() => _driver.FindElement(By.CssSelector(lblCurrentTab)).Displayed;

        public bool IsUpcomingTabDisplayed() => _driver.FindElement(By.CssSelector(lblUpcomingTab)).Displayed;

        public bool IsThrowbackTabDisplayed() => _driver.FindElement(By.CssSelector(lblThrowbackTab)).Displayed;
        #endregion

        public SeriesPage GoToSeriesByTitle(string SeriesTextName)
        {
            _driver.FindElement(By.XPath("//div[@class = 'tile__title'][text()='" + SeriesTextName + "']")).Click();
            return new SeriesPage(_driver);
        }
    }
}