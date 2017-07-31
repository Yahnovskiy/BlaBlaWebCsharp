using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BlaBlaTest
{
    public static class TestHelpers
    {
        public static void AddToCurrentFeatureContext(string key, object obj)
        {
            try
            {
                FeatureContext.Current.Add(key, obj);
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"'{key}' key already present in FeatureContext");
            }
        }
    }
}
