using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Autotests.PageModel;
using Autotests.PageModel.BaseElements;
using OpenQA.Selenium;
using Autotests.PageModel.IndexPage;

namespace Autotests.Tests
{
    [TestFixture]
    public class BasicTests
    {
        const string nbcIndexPage = "https://www.nbc.com/";
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            new AnyPage(driver).GoToIndexPage();
            new NbcIndexPage(driver).WaitForPageLoaded();
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }

        [Test]
        public void MenuNavigationOnShowsPageTest()
        {
            Assert.That(new NbcIndexPage(driver)
                .ClickShowsMenuLnk()
                .IsAllTabDisplayed(), Is.True, "Не открылась таба All");

            Assert.That(new ShowsPage(driver)
                .ClickCurrentTab()
                .IsCurrentTabDisplayed(), Is.True, "Не открылась таба Current");

            Assert.That(new ShowsPage(driver)
                .ClickUpcomingTab()
                .IsUpcomingTabDisplayed(), Is.True, "Не открылась таба Upcoming");

            Assert.That(new ShowsPage(driver)
                .ClickThrowbackTab()
                .IsThrowbackTabDisplayed, Is.True, "Не открылась таба Throwback");

            Assert.That(new ShowsPage(driver)
                .ClickAllTab()
                .IsAllTabDisplayed(), Is.True, "Не открылась таба All");
        }

        [Test]
        public void MainMenuNavigationTest()
        {
            Assert.That(new AnyPage(driver)
                .ClickEpisodesMenuLnk()
                .WaitForPageLoaded()
                .IsEpisodesPageOpened(), Is.True, "Не открылась страница Episodes");

            Assert.That(new AnyPage(driver)
                .ClickScheduleMenuLnk()
                .WaitForPageLoaded()
                .IsSchedulePageOpened(), Is.True, "Не открылась страница Schedule");

            Assert.That(new AnyPage(driver)
                .ClickNewsAndSportsMenuLnk()
                .WaitForPageLoaded()
                .IsNewsAndSportsPageOpened(), Is.True, "Не открылась страница News&Sports");

            Assert.That(new AnyPage(driver)
               .ClickShopMenuLnk()
               .IsShopPageOpened(), Is.True, "Не открылась страница Shop");

            new AnyPage(driver).GoToIndexPage().WaitForPageLoaded();

            Assert.That(new AnyPage(driver)
                .ClickAppMenuLnk()
                .WaitForPageLoaded()
                .IsAppPageOpened(), Is.True, "Не открылась страница App");

            Assert.That(new AnyPage(driver)
               .ClickSearchMenuLnk()
               .WaitForPageLoaded()
               .IsSearchPageOpened(), Is.True, "Не открылась страница Search");

            Assert.That(new AnyPage(driver)
               .ClickShowsMenuLnk()
               .WaitForPageLoaded()
               .IsAllTabDisplayed(), Is.True, "Не открылась страница Shows");
        }

        [Test]
        public void ActorPageTest()
        {
            var seriesTitle = "The Blacklist";
            var actorsCount = 7;
            var actorSpader = "James Spader";
            var actorMarno = "Mozhan Marnò";
            var actorTawfiq = "Hisham Tawfiq";
            var actorBoone = "Megan Boone";

            Assert.That(() => new AnyPage(driver)
                .ClickShowsMenuLnk()
                .WaitForPageLoaded()
                .IsSeriesDisplayed(seriesTitle), Is.True.After(5 * 1000, 1000), $"Не отображается сериал: {seriesTitle}");

            var castpage = new ShowsPage(driver)
                .GoToSeriesPageByTitle(seriesTitle)
                .ClickAddToFavorites()
                .GoToCastPage()
                .WaitForPageLoaded();

            Assert.That(() => castpage.GetActorsCount(), Is.EqualTo(actorsCount).After(5000, 1000), "Не совпало количество актёров");
            Assert.That(castpage.IsActorDisplayed(actorSpader), Is.True, $"Не отображается актер: {actorSpader}");
            Assert.That(castpage.IsActorDisplayed(actorMarno), Is.True, $"Не отображается актер: {actorMarno}");
            Assert.That(castpage.IsActorDisplayed(actorTawfiq), Is.True, $"Не отображается актер: {actorTawfiq}");

            castpage.GoToActorPage(actorBoone).WaitForPageLoaded();

            Assert.That(new ActorPage(driver)
                .ClickMore()
                .IsLessBtnDisplayed(), Is.True, "Не отображатеся кнопка Less");
        }
    }
}