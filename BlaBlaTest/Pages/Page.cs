using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlaBlaTest
{
    public class Page
    {
    protected WebDriverWait Wait { get; }
    protected DefaultWait<IWebDriver> FluentWait;
    protected IWebDriver _driver;

        public Page(IWebDriver driver)
    {
        _driver = driver;
        Wait = new WebDriverWait(_driver, new TimeSpan(0, 0, 0, 30));

        FluentWait = new DefaultWait<IWebDriver>(driver);
        FluentWait.Timeout = TimeSpan.FromSeconds(30);
        FluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
        FluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));

        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        PageFactory.InitElements(_driver, this);
        //Wait.Until(driver1 => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
    }


        public static bool ElementIsPresent(IWebElement element)
        {
            try
            {
                return element.Displayed;
            }
            catch (NoSuchElementException)
            {                
                return false;
            }
            
        }

        public static bool IsBusinessDay(DateTime date)
        {
            switch (date.DayOfWeek)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    return true;
                default:
                    return false;
            }
        }


    }
 }


    

