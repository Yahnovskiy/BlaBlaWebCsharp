using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BlaBlaTest
{
    public class RepeatAction : Page
    {
        public RepeatAction(IWebDriver driver) : base(driver) { }

        [FindsBy(How = How.XPath, Using = ".//span[@class = 'Header-navigationAvatar']")]
        IWebElement LoggedInnavigationAvatar { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='/poshuk-poyizdki']")]
        IWebElement SearchButtonScreen { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='search_from_name']")]
        IWebElement SearchFromField { get; set; }

        public void MyAction()
        {
            //LoggedInnavigationAvatar.Click();
            var mon = GetStartOfTheWeek(DateTime.Today, DayOfWeek.Monday);            
            var bd = GetBusinessDays(mon, 5).ToArray();
            foreach (var eachBD in bd)
            {
                SearchButtonScreen.Click();
                SearchFromField.SendKeys(eachBD.ToString());
                SearchFromField.Clear();
                
            }
        }
        
        

        public static List<DateTime> GetBusinessDays(DateTime dayOfWeek, double daysCount)
        {
            var businessDays = new List<DateTime>();
           
            while (daysCount >= 0)
            {
                var day = dayOfWeek.AddDays(daysCount).Date;
                if (IsBusinessDay(day))
                    businessDays.Add(day);

                daysCount -= 1;
            }
            
            return businessDays;
        }

        public static new bool IsBusinessDay(DateTime date)
        {
            var day = date.DayOfWeek;
            var res = (day == DayOfWeek.Saturday || day == DayOfWeek.Sunday) ? false : true;
            return res;
        }

        public static DateTime GetStartOfTheWeek(DateTime date, DayOfWeek startDayOfWeek)
        {
            while (date.DayOfWeek != startDayOfWeek)
            {
                date = date.AddDays(-1);
            }
            return date;
        }


    }
}
