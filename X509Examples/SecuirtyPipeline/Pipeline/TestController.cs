using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net.Http;

namespace SecurityPipeline.Pipeline
{
    public class TestController:ApiController

    {
        public IHttpActionResult Get () { 
        Helper.Write("Controller", User);

        Helper.Write("Controller - alternative", Request.GetRequestContext().Principal);
    



        return Ok();
        }
    }
}