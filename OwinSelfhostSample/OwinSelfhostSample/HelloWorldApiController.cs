using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace OwinSelfhostSample
{
    class HelloWorldApiController : ApiController
    {
        [HttpGet]
        public string Get()
        {
            return "Hello World";
        }

    }
}
