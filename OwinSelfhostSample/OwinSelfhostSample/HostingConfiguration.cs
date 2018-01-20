using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace OwinSelfhostSample
{
    public class HostingConfiguration : ServiceControl
    {
        private IDisposable _webApplication;
        public bool Start(HostControl hostControl)
        {
            Trace.WriteLine("Starting the service");
            _webApplication = WebApp.Start<OwinConfiguration>("http://localhost:8090");
            return true;
        }
        public bool Stop(HostControl hostControl)
        {
            _webApplication.Dispose();
            return true;
        }
    }
}
