using Autotests.PageModel.BaseElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autotests.PageModel
{
    public class SchedulePage : AnyPage
    {
        public SchedulePage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        private const string cmpCalendar = ".schedule__days";

        public bool IsSchedulePageOpened() => WaitForElementPresent(By.CssSelector(cmpCalendar)) != null;

        public new SchedulePage WaitForPageLoaded()
        {
            base.WaitForPageLoaded();
            return this;
        }
    }
}
