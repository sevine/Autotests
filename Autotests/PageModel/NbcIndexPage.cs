using Autotests.PageModel.BaseElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Autotests.PageModel.IndexPage
{
    public class NbcIndexPage : AnyPage
    {        
        public NbcIndexPage (IWebDriver driver) : base (driver)
        {
            _driver = driver;
        }        
    }
}
