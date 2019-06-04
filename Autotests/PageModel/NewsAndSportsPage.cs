using Autotests.PageModel.BaseElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autotests.PageModel
{
    class NewsAndSportsPage : BasePage
    {
        public NewsAndSportsPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        private const string divNewsAndSports = "//div[@class='navigation__item__group navigation__item__group--news-sports']";

        public bool IsNewsAndSportsPageOpened() => _driver.FindElement(By.XPath(divNewsAndSports)).Displayed;
    }
}
