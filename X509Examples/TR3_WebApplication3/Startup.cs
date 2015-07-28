using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TR3_WebApplication3.Startup))]
namespace TR3_WebApplication3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
