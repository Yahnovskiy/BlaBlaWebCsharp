using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BlaBlaTest
{
    public class SearchPage : Page
    {
        public SearchPage(IWebDriver driver) : base(driver){ }

        [FindsBy(How = How.XPath, Using = ".//*[@class='search-date date-picker hasDatepicker']")]
        IWebElement CalendarPicker { get; set; }
            
        [FindsBy(How = How.XPath, Using = ".//*[@id='search_from_name']")]
        IWebElement SearchFromField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='search_to_name']")]
        IWebElement SearchToField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='search-form']/input")]
        IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='/poshuk-poyizdki']")]
        IWebElement SearchButtonScreen { get; set; }

        public void FillSearchForm(SearchModel search)
        {
            SearchButtonScreen.Click();
            ChooseDate(search.WhenDate);
            ChooseFrom(search.From);
        }

       

        public void ChooseDate(string searchDate)
        {
            
            CalendarPicker.Click();
            _driver.FindElement(By.XPath(".//*[@class='ui-datepicker-calendar']//a[. ='" + searchDate + "']")).Click();
        }

        private void ChooseFrom(string from)
        {
            SearchFromField.Click();
            SearchFromField.SendKeys(from);
            //
        }


    }
}
