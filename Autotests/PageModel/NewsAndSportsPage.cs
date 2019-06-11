using Autotests.PageModel.BaseElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autotests.PageModel
{
    public class NewsAndSportsPage : AnyPage
    {
        public NewsAndSportsPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        private const string divNewsAndSports = "//div[@class='navigation__item__group navigation__item__group--news-sports']";

        public bool IsNewsAndSportsPageOpened() => WaitForElementPresent(By.XPath(divNewsAndSports)) != null;

        public new NewsAndSportsPage WaitForPageLoaded()
        {
            base.WaitForPageLoaded();
            return this;
        }
    }
}
