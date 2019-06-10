using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Autotests.PageModel;
using Autotests.PageModel.BaseElements;
using OpenQA.Selenium;

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
                .IsEpisodesPageOpened(), Is.True, "Не открылась страница Episodes");

            Assert.That(new AnyPage(driver)
                .ClickScheduleMenuLnk()
                .IsSchedulePageOpened(), Is.True, "Не открылась страница Schedule");

            Assert.That(new AnyPage(driver)
                .ClickNewsAndSportsMenuLnk()
                .IsNewsAndSportsPageOpened(), Is.True, "Не открылась страница News&Sports");

            Assert.That(new AnyPage(driver)
               .ClickShopMenuLnk()
               .IsShopPageOpened(), Is.True, "Не открылась страница Shop");

            new AnyPage(driver).GoToIndexPage();

            Assert.That(new AnyPage(driver)
                .ClickAppMenuLnk()
                .IsAppPageOpened(), Is.True, "Не открылась страница App");

            Assert.That(new AnyPage(driver)
               .ClickSearchMenuLnk()
               .IsSearchPageOpened(), Is.True, "Не открылась страница Search");

            Assert.That(new AnyPage(driver)
               .ClickShowsMenuLnk()
               .IsAllTabDisplayed(), Is.True, "Не открылась страница Shows");
        }

        [Test]
        public void ActorPageTest()
        {
            string seriesTitle = "The Blacklist";
            int actorsCount = 7;
            string actorSpader = "James Spader";
            string actorMarno = "Mozhan Marnò";
            string actorTawfiq = "Hisham Tawfiq";
            string actorBoone = "Megan Boone";

            Assert.That(() => new AnyPage(driver)
                .ClickShowsMenuLnk()            
                .IsSeriesDisplayed(seriesTitle), Is.True.After(5 * 1000, 1000), $"Не отображается сериал: {seriesTitle}");

            var _castpage = new ShowsPage(driver)
                .GoToSeriesPageByTitle(seriesTitle)
                .ClickAddToFavorites()
                .GoToCastPage();

            Assert.That(_castpage.GetActorsCount(), Is.EqualTo(actorsCount), "Не совпало количество актёров");
            Assert.That(_castpage.IsActorDisplayed(actorSpader), Is.True, $"Не отображается актер: {actorSpader}");
            Assert.That(_castpage.IsActorDisplayed(actorMarno), Is.True, $"Не отображается актер: {actorMarno}");
            Assert.That(_castpage.IsActorDisplayed(actorTawfiq), Is.True, $"Не отображается актер: {actorTawfiq}");

            _castpage.GoToActorPage(actorBoone);

            Assert.That(new ActorPage(driver)
                .ClickMore()
                .IsLessBtnDisplayed(), Is.True, "Не отображатеся кнопка Less");
        }
    }
}