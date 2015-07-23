using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WindowAuthentication.Models;
using System.Security.Claims;

namespace WindowAuthentication.Controllers
{
  //  [Authorize]
    public class IdentityController : ApiController
    {

        public IEnumerable<ViewClaim> Get ()
        {
            var principal = User as ClaimsPrincipal;

            return from c in principal.Claims
                   select new ViewClaim
                   {
                       Type = c.Type,
                       Value = c.Value
                   };
        }
    }
}