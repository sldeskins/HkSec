using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace SecurityPipeline
{
    public class TestAurthorizationFilterAttribute : AuthorizeAttribute
    {

        protected override bool IsAuthorized ( System.Web.Http.Controllers.HttpActionContext actionContext )
        {
            Helper.Write("Authorization", actionContext.RequestContext.Principal);

            //return base.IsAuthorized(actionContext);
            return true;
        }
    }
}