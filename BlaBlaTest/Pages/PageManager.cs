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
        
        public PageManager(IWebDriver driver)
        {
            PageLogin = new LoginPage(driver);
            PageSSearch = new SearchPage(driver);
        }
    }
}
