using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlaBlaTest
{
    public class PageManager
    {
        public LoginPage PageLogin { get; }
        public SearchPage PageSSearch { get; }
        public HomePage PageHome { get; }
        public RepeatAction ActionRepeat { get; }

        public PageManager(IWebDriver driver)
        {
            PageLogin = new LoginPage(driver);
            PageSSearch = new SearchPage(driver);
            PageHome = new HomePage(driver);
            ActionRepeat = new RepeatAction(driver);
        }
    }
}
