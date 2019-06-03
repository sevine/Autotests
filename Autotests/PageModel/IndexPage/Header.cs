using System;
using System.Collections.Generic;
using System.Text;

namespace Autotests.PageModel.IndexPage
{
    public class Header
    {
        public const string lnkShows = "a[href='/shows']";
        public const string lnkEpisodes = "a[href='/video']";
        public const string lnkSchedule = "a[href='/schedule']";
        public const string lnkNewsAndSports = "//span[contains(text(), 'Sport')]/..";
        public const string lnkShop = "//span[contains(text(), 'Shop')]/..";
        public const string lnkApp = "a[href='/apps']";
        public const string lnkSearch = "//button[@class='navigation__search navigation__item__title']";
    }
}
