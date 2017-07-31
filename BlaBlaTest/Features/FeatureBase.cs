using NUnit.Framework;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using BlaBlaTest.WebDriver;

namespace BlaBlaTest
{
    [Binding]
    [TestFixture]
    public class FeatureBase
    {
        static IWebDriver Driver;
        protected Browser WebBrowser;
        protected PageManager PM;
        protected ITestEnvironmentData Env;

        [BeforeScenario]
        [SetUp]
        public void BeforeScenario()
        {
            Env = new StageBetaTestEnvironmentData();            
            Driver = WebDriverFactory.GetInstance(Browser.Firefox);

            Driver.Url = Env.BaseUrl;
                       
            PM = new PageManager(Driver);
            TestHelpers.AddToCurrentFeatureContext(TestData.PageManager, PM);
            //PM.PageLogin.LogIn(Env.UserNameToLogin, Env.UserPasswordToLogin);
      }

        [AfterScenario]
        [TearDown]
        public void AfterScenario()
        {
            Driver.Quit();            
        }
    }
}