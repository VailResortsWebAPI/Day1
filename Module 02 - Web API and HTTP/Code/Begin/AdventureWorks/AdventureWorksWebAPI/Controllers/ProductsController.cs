using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AdventureWorksWebAPI.Controllers
{
    public class ProductsController : ApiController
    {
        public string Get()
        {
            return "Hello World";
        }

        public string Get(string id)
        {
            return "You requested Product #" + id;
        }

        public string Post([FromBody]string body)
        {
            return "Post: " + body;
        }

        public string Put(int id, [FromBody]string body)
        {
            return "Put: " + body + " @ " + id;
        }

        public string Delete(int id)
        {
            return "Delete: " + id;
        }
    }
}
