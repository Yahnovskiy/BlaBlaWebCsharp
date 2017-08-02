using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlaBlaTest
{
   public class TestData
    {
        public static Dictionary<string, object> Data = new Dictionary<string, object>();

        public static T Get<T>(string key)

        {
            try
            {
                Console.WriteLine($"searchig for key: {key}");
                return (T)Convert.ChangeType(Data[key], typeof(T));
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine($"Cant get value for key '{key}':\n {ex}");
                //
                return (T)Convert.ChangeType(null, typeof(T));
            }
        }

        public static string Driver = "driver";
        public static string Alias = "Alias";
        public static string RestService = "Rest";
        public static string Today = "Today";
        public static string BaseUrl = "Base URL";
        public static string PageManager = "Page Manager";
        public static string UserPassword2 = "User Password";
        public static string AllFaciilities = "All Facilities";
        public static string FacilityForTest = "Facility For Test";
        public static string FacilityResources = "Facility Resources";
        public static string ColleaguesList = "Colleagues List";
        public static string TimeFormat = "Time format";
        public static string DateFormat = "Date format";
        public static string TestEnv = "Test environment";
        public static string CurrentPlatform = "Current Platform";
        public static string TodayOfficeName = "Today Office Name";
        public static string NearbyLocations = "Nearby Locations";
        public static string FailedTestsFile = "../../../Reports/failedTests.txt";
        public static string AnotherCity = "Another City";
        public static string SearchForm = "Search form";
        
    }
}