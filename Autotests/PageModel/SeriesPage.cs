using Autotests.PageModel.BaseElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autotests.PageModel
{
    public class SeriesPage : BasePage
    {
        public SeriesPage (IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public bool IsSeriesPageOpened(string SeriesPageTitle) => _driver.FindElement(By.XPath("//div[@class = 'slideshow__title'][text()='" + SeriesPageTitle + "']")).Displayed;
    }
}
