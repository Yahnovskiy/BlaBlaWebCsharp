using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlaBlaTest.WebDriver
{
    public enum Browser { Chrome, Firefox, Ie, Phantom }


    class WebDriverFactory
    {
        private static IWebDriver Driver = null;

        public static IWebDriver GetInstance(String gridHubUrl, Browser browser)
        {
            if (Driver != null)
                return Driver;

            if (string.IsNullOrEmpty(gridHubUrl))
                return GetInstance(browser);

            DesiredCapabilities capabilities = new DesiredCapabilities();

            switch (browser)
            {
                case Browser.Chrome:
                    capabilities = DesiredCapabilities.Chrome();
                    capabilities.SetCapability(CapabilityType.BrowserName, "chrome");
                    break;
                case Browser.Firefox:
                    capabilities = DesiredCapabilities.Firefox();

                    capabilities.SetCapability(CapabilityType.BrowserName, "firefox");
                    break;
                case Browser.Ie:
                    capabilities = DesiredCapabilities.InternetExplorer();
                    capabilities.SetCapability(CapabilityType.BrowserName, "InternetExplorer");
                    break;
                case Browser.Phantom:
                    capabilities = DesiredCapabilities.PhantomJS();
                    capabilities.SetCapability(CapabilityType.BrowserName, "PhantomJS");
                    break;
                default:
                    //throw new Exception("Unknown driver type");
                    break;
            }

            capabilities.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));
            Driver = new RemoteWebDriver(new Uri(gridHubUrl), capabilities);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            return Driver;
        }



        /*
  * Factory method to return a WebDriver instance given the browser to hit
  * @param browser : String representing the local browser to hit
  * @return WebDriver instance
  */
        public static IWebDriver GetInstance(Browser browser)
        {

            if (Driver != null)
                return Driver;

            switch (browser)
            {
                case Browser.Chrome:
                    Driver = new ChromeDriver();
                    break;
                case Browser.Firefox:
                    var profile = new FirefoxProfile { EnableNativeEvents = false };
                    profile.SetPreference("geo.prompt.testing", true);
                    profile.SetPreference("geo.prompt.testing.allow", true);
                    profile.SetPreference("geo.wifi.uri", "./brussels.json");
                    Driver = new FirefoxDriver(profile);
                    break;
                case Browser.Ie:
                    Driver = new InternetExplorerDriver();
                    break;
                case Browser.Phantom:
                    Driver = new PhantomJSDriver();
                    break;
                default:
                    break;
            }
            return Driver;
        }

    }
}