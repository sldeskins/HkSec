using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TR4_WebApplication4.Startup))]
namespace TR4_WebApplication4
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
