using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlaBlaTest
{
    public class StageBetaTestEnvironmentData : ITestEnvironmentData
    {
        public string BaseUrl { get; } = "https://www.blablacar.com.ua/";
        public string UserNameToLogin { get; } = "bigbubble.e@bigmir.net";
        public string UserPasswordToLogin { get; } = "bigbubble";
        //public List<string> OfficesForTest { get; } = new List<string> { "9242", "9262", "9402" };
    }
}
