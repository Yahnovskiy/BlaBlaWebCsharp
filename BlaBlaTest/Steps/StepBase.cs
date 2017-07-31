using TechTalk.SpecFlow;

namespace BlaBlaTest
{
    public class StepBase : Steps
    {
        protected PageManager Pages;

        public StepBase()
        {
            Pages = FeatureContext.Current.Get<PageManager>(TestData.PageManager);
        }
    }
}
