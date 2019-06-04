using OpenQA.Selenium;

namespace Autotests.PageModel.BaseElements
{
    public class BasePage
    {
        protected IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}