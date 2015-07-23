using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security.Google;
using Microsoft.Owin.Security.OAuth;

namespace Tokens
{
    public class KatanaAuthentication
    {
        public void Configuration ( IAppBuilder app )
        {
            // Enable the application to use a cookie to store information for the signed in user
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Authentication/Login")
            });

            app.UseGoogleAuthentication(new GoogleAuthenticationOptions
            {
                AuthenticationType = "Google",
                //more options
            });
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions
            {
                AuthenticationType = "Bearer",
                //more options
            });
        }
    }
}
