using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimaiDotNet.Console
{
    public class SampleOptions
    {
        public const string Sample = "Sample";
        public string UserName { get; }
        public string Password { get; }
        public string BaseUrl { get; }

        public SampleOptions(string baseUrl, string userName, string password)
        {
            UserName = userName;
            Password = password;
            BaseUrl = baseUrl;
        }
    }
}
