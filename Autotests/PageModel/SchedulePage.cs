using Autotests.PageModel.BaseElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autotests.PageModel
{
    class SchedulePage : BasePage
    {
        public SchedulePage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        private const string cmpCalendar = ".schedule__days";

        public bool IsSchedulePageOpened() => _driver.FindElements(By.CssSelector(cmpCalendar)).Count > 0;
    }
}
