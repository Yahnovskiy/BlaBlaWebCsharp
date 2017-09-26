using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BlaBlaTest
{
    [Binding]
    public class SearchSteps : StepBase
    {
        [Given("I fill search field")]
        public void GivenIFillSearchField(Table tableX)
        {
            SearchModel search = tableX.CreateInstance<SearchModel>();
            search.WhenDate = DateTime.Now.AddDays(search.DaysFromNow).Day.ToString();
            Pages.PageSSearch.FillSearchForm(search);

            //BlaBlaSearchModel.WhenDate = 
            //TestHelpers.AddToCurrentFeatureContext(TestData.SearchForm, uiSearch);

        }
    }
}
