using Autotests.PageModel.IndexPage;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Autotests.PageModel.BaseElements
{
    public class AnyPage : BasePage
    {
        const string nbcIndexPage = "https://www.nbc.com/";

        public AnyPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        #region locators
        private const string lnkShows = "a[href='/shows']";
        private const string lnkEpisodes = "a[href='/video']";
        private const string lnkSchedule = "a[href='/schedule']";
        private const string lnkNewsAndSports = ".navigation__item.navigation__item--group";
        private const string lnkShop = "//span[contains(text(), 'Shop')]/..";
        private const string lnkApp = "a[href='/apps']";
        private const string lnkSearch = "//button[@class='navigation__search navigation__item__title']";
        #endregion

        #region ClickMethods
        public ShowsPage ClickShowsMenuLnk()
        {
            _driver.FindElement(By.CssSelector(lnkShows)).Click();            
            return new ShowsPage(_driver);
        }

        public EpisodesPage ClickEpisodesMenuLnk()
        {
            _driver.FindElement(By.CssSelector(lnkEpisodes)).Click();
            return new EpisodesPage(_driver);
        }

        public SchedulePage ClickScheduleMenuLnk()
        {
            _driver.FindElement(By.CssSelector(lnkSchedule)).Click();
            return new SchedulePage(_driver);
        }

        public NewsAndSportsPage ClickNewsAndSportsMenuLnk()
        {
            _driver.FindElement(By.CssSelector(lnkNewsAndSports)).Click();
            return new NewsAndSportsPage(_driver);
        }

        public ShopPage ClickShopMenuLnk()
        {
            _driver.FindElement(By.XPath(lnkShop)).Click();
            return new ShopPage(_driver);
        }

        public AppPage ClickAppMenuLnk()
        {
            _driver.FindElement(By.CssSelector(lnkApp)).Click();
            return new AppPage(_driver);
        }

        public SearchPage ClickSearchMenuLnk()
        {
            _driver.FindElement(By.XPath(lnkSearch)).Click();
            return new SearchPage(_driver);
        }

        public NbcIndexPage GoToIndexPage()
        {
            _driver.Navigate().GoToUrl(nbcIndexPage);
            return new NbcIndexPage(_driver);
        }
        #endregion

        #region AssertMethods
        public bool IsElementPresent(By locator) => _driver.FindElements(locator).Count > 0;
        #endregion

        #region DoMethods
        public IWebElement WaitForElementPresent(By locator, int maxTimeOfWaiting = 15)
        {
            new WebDriverWait(_driver, TimeSpan.FromSeconds(maxTimeOfWaiting))
                .Until(q => IsElementPresent(locator));
            return _driver.FindElement(locator);
        }

        public AnyPage WaitForElementNotPresent(By locator, int maxTimeOfWaiting = 15)
        {
            new WebDriverWait(_driver, TimeSpan.FromSeconds(maxTimeOfWaiting))
                .Until(q => !IsElementPresent(locator));
            return this;
        }

        public AnyPage WaitForPageLoaded()
        {
            WaitForElementNotPresent(By.CssSelector(".basic-loading-page .basic-loading-page--show-page"));
            return this;
        }
        #endregion
    }
}