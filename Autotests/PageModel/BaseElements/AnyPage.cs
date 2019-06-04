using Autotests.PageModel.IndexPage;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Autotests.PageModel.BaseElements
{
    class AnyPage : BasePage
    {
        const string nbcIndexPage = "https://www.nbc.com/";

        public AnyPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        #region locators
        public const string lnkShows = "a[href='/shows']";
        public const string lnkEpisodes = "a[href='/video']";
        public const string lnkSchedule = "a[href='/schedule']";
        public const string lnkNewsAndSports = "//span[contains(text(), 'Sport')]/..";
        public const string lnkShop = "//span[contains(text(), 'Shop')]/..";
        public const string lnkApp = "a[href='/apps']";
        public const string lnkSearch = "//button[@class='navigation__search navigation__item__title']";
        #endregion

        #region ClickMethods
        public ShowsPage ClickOnShowsMenuLnk()
        {
            _driver.FindElement(By.CssSelector(lnkShows)).Click();
            Thread.Sleep(5 * 1000);
            return new ShowsPage(_driver);
        }

        public EpisodesPage ClickOnEpisodesMenuLnk()
        {
            _driver.FindElement(By.CssSelector(lnkEpisodes)).Click();
            Thread.Sleep(5 * 1000);
            return new EpisodesPage(_driver);
        }

        public SchedulePage ClickOnScheduleMenuLnk()
        {
            _driver.FindElement(By.CssSelector(lnkSchedule)).Click();
            Thread.Sleep(5 * 1000);
            return new SchedulePage(_driver);
        }

        public NewsAndSportsPage ClickOnNewsAndSportsMenuLnk()
        {
            _driver.FindElement(By.XPath(lnkNewsAndSports)).Click();
            Thread.Sleep(5 * 1000);
            return new NewsAndSportsPage(_driver);
        }

        public ShopPage ClickOnShopMenuLnk()
        {
            _driver.FindElement(By.XPath(lnkShop)).Click();
            Thread.Sleep(5 * 1000);
            return new ShopPage(_driver);
        }

        public AppPage ClickOnAppMenuLnk()
        {
            _driver.FindElement(By.CssSelector(lnkApp)).Click();
            Thread.Sleep(5 * 1000);
            return new AppPage(_driver);
        }

        public SearchPage ClickOnSearchMenuLnk()
        {
            _driver.FindElement(By.XPath(lnkSearch)).Click();
            Thread.Sleep(5 * 1000);
            return new SearchPage(_driver);
        }
        #endregion

        public NbcIndexPage GoToIndexPage()
        {
            _driver.Navigate().GoToUrl(nbcIndexPage);
            Thread.Sleep(5 * 1000);
            return new NbcIndexPage(_driver);
        }
    }
}