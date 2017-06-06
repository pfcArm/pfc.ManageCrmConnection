using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestPerformanceConnection.Controllers
{
    public class OneSearchController : ApiController
    {
        //http://localhost/api/OneSearch?s=text
        public object Get([FromUri]string s)
        {
            return new { result = true };
        }
    }
}
