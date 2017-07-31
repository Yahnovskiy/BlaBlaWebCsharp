using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlaBlaTest
{
    public interface ITestEnvironmentData
    {        
        string BaseUrl { get; }
        string UserNameToLogin { get; }
        string UserPasswordToLogin { get; }
    }
}
