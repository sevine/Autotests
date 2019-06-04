using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Autotests.PageModel;
using Autotests.PageModel.BaseElements;

namespace Autotests.Tests
{
    [TestFixture]
    public class BasicTests
    {
        const string nbcIndexPage = "https://www.nbc.com/";
        ChromeDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            new AnyPage(driver).GoToIndexPage();
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }

        [Test]
        public void MenuNavigationOnShowsPageTest()
        {
            Assert.That(new AnyPage(driver)
                .ClickOnShowsMenuLnk()
                .IsAllTabDisplayed(), Is.True, "Не открылась таба All");

            Assert.That(new ShowsPage(driver)
                .ClickOnCurrentTab()
                .IsCurrentTabDisplayed(), Is.True, "Не открылась таба Current");

            Assert.That(new ShowsPage(driver)
                .ClickOnUpcomingTab()
                .IsUpcomingTabDisplayed(), Is.True, "Не открылась таба Upcoming");

            Assert.That(new ShowsPage(driver)
                .ClickOnThrowbackTab()
                .IsThrowbackTabDisplayed, Is.True, "Не открылась таба Throwback");

            Assert.That(new ShowsPage(driver)
                .ClickOnAllTab()
                .IsAllTabDisplayed(), Is.True, "Не открылась таба All");
        }

        [Test]
        public void MainMenuNavigationTest()
        {
            Assert.That(new AnyPage(driver)
                .ClickOnEpisodesMenuLnk()
                .IsEpisodesPageOpened(), Is.True, "Не открылась страница Episodes");

            Assert.That(new AnyPage(driver)
                .ClickOnScheduleMenuLnk()
                .IsSchedulePageOpened(), Is.True, "Не открылась страница Schedule");

            Assert.That(new AnyPage(driver)
                .ClickOnNewsAndSportsMenuLnk()
                .IsNewsAndSportsPageOpened(), Is.True, "Не открылась страница News&Sports");

            Assert.That(new AnyPage(driver)
               .ClickOnShopMenuLnk()
               .IsShopPageOpened(), Is.True, "Не открылась страница Shop");

            new AnyPage(driver).GoToIndexPage();

            Assert.That(new AnyPage(driver)                
                .ClickOnAppMenuLnk()
                .IsAppPageOpened(), Is.True, "Не открылась страница App");

            Assert.That(new AnyPage(driver)
               .ClickOnSearchMenuLnk()
               .IsSearchPageOpened(), Is.True, "Не открылась страница Search");

            Assert.That(new AnyPage(driver)
               .ClickOnShowsMenuLnk()
               .IsAllTabDisplayed(), Is.True, "Не открылась страница Shows");
        }
    }
}
