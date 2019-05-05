using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetDemo
{
    public class MyClass
    {
        public MyClass()
        {
            async Task DownloadAsync()
            {
                HttpClient httpClient = new HttpClient();
                await httpClient.GetStringAsync("");
            }
        }
    }
}
