//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;

//namespace BlaBlaTest
//{
//    public class LoginPage : Page
//    {
//        public LoginPage(IWebDriver driver) : base(driver) { }

//        [FindsBy(How = How.XPath, Using = "")]
//        IWebElement LoginButton { get; set; }

//        [FindsBy(How = How.XPath, Using = "")]
//        IWebElement UserNameInput { get; set; }

//        [FindsBy(How = How.XPath, Using = "")]
//        IWebElement PasswordInput { get; set; }

//        [FindsBy(How = How.XPath, Using = "")]
//        IWebElement SubmitButton { get; set; }

//        public void LogIn(string username, string password)
//        {
//            LoginButton.Click();
//            UserNameInput.Clear();
//            UserNameInput.SendKeys(username);
//            PasswordInput.Clear();
//            PasswordInput.SendKeys(password);
//            SubmitButton.Click();
//        }
//    }
//}
