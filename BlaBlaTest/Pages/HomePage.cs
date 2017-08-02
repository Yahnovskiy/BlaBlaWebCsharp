using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace BlaBlaTest
{
    public class HomePage : Page
    {
        public HomePage(IWebDriver driver) : base(driver) { }

        [FindsBy(How = How.XPath, Using = ".//span[@class = 'HHeader-navigationAvatar']")]
        IWebElement LoggedInnavigationAvatar { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='/viyti']")]
        IWebElement LogOutButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='/poshuk-poyizdki']")]
        IWebElement SearchButtonScreen { get; set; }



        public void IsUserProfileVisible()
        {
            //FluentWait.Until(ExpectedConditions.ElementToBeClickable(LoggedInnavigationAvatar));
            Assert.AreEqual(true, ElementIsPresent(LoggedInnavigationAvatar)); // Visible Works
        }
    }
}



        
    
 

