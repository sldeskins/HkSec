using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TR1_WebApplication1.Startup))]
namespace TR1_WebApplication1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
