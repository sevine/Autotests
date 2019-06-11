using Autotests.PageModel.BaseElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autotests.PageModel
{
    public class ShopPage : AnyPage
    {
        public ShopPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        private const string nbsStoreUrl = "https://www.nbcstore.com/";

        public bool IsShopPageOpened() => WaitForElementPresent(By.CssSelector($"a[href='{nbsStoreUrl}']")) != null;
    }
}
