using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Autotests.PageModel.BaseElements;

namespace Autotests.PageModel
{
    public class ShowsPage : AnyPage
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
        public ShowsPage ClickAllTab()
        {
            _driver.FindElement(By.CssSelector(lnkAllTab)).Click();
            return WaitForPageLoaded();
        }

        public ShowsPage ClickCurrentTab()
        {
            _driver.FindElement(By.CssSelector(lnkCurrentTab)).Click();
            return WaitForPageLoaded();
        }

        public ShowsPage ClickUpcomingTab()
        {
            _driver.FindElement(By.CssSelector(lnkUpcomingTab)).Click();
            return WaitForPageLoaded();
        }

        public ShowsPage ClickThrowbackTab()
        {
            _driver.FindElement(By.CssSelector(lnkThrowbackTab)).Click();
            return WaitForPageLoaded();
        }
        #endregion

        #region AssertMethods
        public bool IsAllTabDisplayed() => WaitForElementPresent(By.CssSelector(lblAllTab)) != null;

        public bool IsCurrentTabDisplayed() => WaitForElementPresent(By.CssSelector(lblCurrentTab)) != null;

        public bool IsUpcomingTabDisplayed() => WaitForElementPresent(By.CssSelector(lblUpcomingTab)) != null;

        public bool IsThrowbackTabDisplayed() => WaitForElementPresent(By.CssSelector(lblThrowbackTab)) != null;

        public bool IsSeriesDisplayed(string SeriesTextName) => WaitForElementPresent(By.XPath($"//*[@class='tile__title'][text()='{SeriesTextName}']")) != null;
        #endregion

        #region DoMethods
        public SeriesPage GoToSeriesPageByTitle(string SeriesTextName)
        {
            _driver.FindElement(By.XPath("//div[@class = 'tile__title'][text()='" + SeriesTextName + "']")).Click();            
            return new SeriesPage(_driver);
        }
    
        public new ShowsPage WaitForPageLoaded()
        {
            base.WaitForPageLoaded();
            return this;
        }
        #endregion
    }
}