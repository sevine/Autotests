using Autotests.PageModel.BaseElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autotests.PageModel
{
    class ShopPage : BasePage
    {
        public ShopPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        private const string nbsStoreUrl = "https://www.nbcstore.com";

        public bool IsShopPageOpened()
        {
            return _driver.Url.Contains(nbsStoreUrl);
        }
    }
}
