using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Autotests.PageModel.IndexPage;
using OpenQA.Selenium;

namespace Autotests.Tests
{
    [TestFixture]
    public class BasicTests
    {
        const string nbcIndexPage = "https://www.nbc.com/";
        ChromeDriver driver;

        [SetUp]
        public void Init()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(nbcIndexPage);
            Thread.Sleep(5000);
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }

        [Test]
        public void MainMenuNavigationTest()
        {
            Thread.Sleep(5000);
        }
    }
}
