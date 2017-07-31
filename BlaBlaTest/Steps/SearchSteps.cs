using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BlaBlaTest
{
    [Binding]
    public class BlaBlaSteps : StepBase
    {
        [Given("I fill search field")]
        public void GivenIFillSearchField(Table table)
        {
            SearchModel search = table.CreateInstance<SearchModel>();
            search.WhenDate = DateTime.Now.AddDays(search.DaysFromNow).ToString("dd");
            Pages.PageSSearch.FillSearchForm(search);

            //BlaBlaSearchModel.WhenDate = 
            //TestHelpers.AddToCurrentFeatureContext(TestData.SearchForm, uiSearch);

        }
    }
}
