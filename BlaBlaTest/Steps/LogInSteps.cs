using System;
using TechTalk.SpecFlow;

namespace BlaBlaTest
{
    [Binding]
    public class LogInSteps : StepBase
    {        
        [Given(@"User profile is visible")]
        public void GivenUserProfileIsVisible()
        {
            Pages.PageHome.IsUserProfileVisible();
        }
    }
}
