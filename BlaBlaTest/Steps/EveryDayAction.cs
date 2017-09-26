using System;
using TechTalk.SpecFlow;

namespace BlaBlaTest
{
    [Binding]
    public class BlaBlaSteps : StepBase
    {        
        [Given(@"Click user profile every day for current week")]
        public void GivenClickUserProfileEveryDayForCurrentWeek()
        {              
             Pages.ActionRepeat.MyAction();            
        }               
    }
}
