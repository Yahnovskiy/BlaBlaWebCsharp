using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BlaBlaTest
{
    public class LoginPage : Page
    {
        public LoginPage(IWebDriver driver) : base(driver) { }
                
        [FindsBy(How = How.XPath, Using = ".//*[@class='Header-navigationText dropdown-toggle']")]
        IWebElement PopupLoginWindow { get; set; }
                
        [FindsBy(How = How.Name, Using = "_username")]
        IWebElement UserNameInput { get; set; }

        [FindsBy(How = How.Name, Using = "_password")]
        IWebElement PasswordInput { get; set; }

        [FindsBy(How = How.Name, Using = "_submit")]
        IWebElement SubmitButton { get; set; }

        public void LogIn(string username, string password)
        {
            PopupLoginWindow.Click();
            UserNameInput.Click();
            UserNameInput.Clear();
            UserNameInput.SendKeys(username);
            PasswordInput.Click();
            PasswordInput.Clear();
            PasswordInput.SendKeys(password);
            SubmitButton.Click();
        }        
    }
}
