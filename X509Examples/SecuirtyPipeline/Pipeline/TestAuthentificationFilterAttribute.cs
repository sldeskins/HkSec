using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Filters;

namespace SecurityPipeline
{
    public class TestAuthentificationFilterAttribute : Attribute, IAuthenticationFilter
    {
        public async Task AuthenticateAsync ( HttpAuthenticationContext context, System.Threading.CancellationToken cancellationToken )
        {
            //// set
            //context.Principal
            //use context.ActionContext.RequestContext.Principal to get what already in the pipeline
            Helper.Write("Authentication", context.ActionContext.RequestContext.Principal);

        }

        public async Task ChallengeAsync ( HttpAuthenticationChallengeContext context, System.Threading.CancellationToken cancellationToken )
        {
            // throw new NotImplementedException();
        }

        public bool AllowMultiple
        {
            get { return false; }
        }
    }
}