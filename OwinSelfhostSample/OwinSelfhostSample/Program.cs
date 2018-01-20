using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace OwinSelfhostSample
{
    class Program
    {
        public static int Main()
        {
            var exitCode = HostFactory.Run(x =>
            {
                x.SetStartTimeout(TimeSpan.FromSeconds(120));
                x.SetStopTimeout(TimeSpan.FromSeconds(120));
                x.Service<HostingConfiguration>();
                x.RunAsLocalSystem();
                x.StartAutomatically();
                x.SetDescription("Web API Service");
                x.SetDisplayName("owin.test");
                x.SetServiceName("owin.test");
            });

            // Create HttpCient and make a request to api/values 
            //HttpClient client = new HttpClient();
            //var response = client.GetAsync("http://localhost:8090/" + "api/Get").Result;
            //Console.WriteLine(response);
            //Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            //Console.ReadLine();

            return (int)exitCode;
        }
    }
}
