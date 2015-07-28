using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TR5_WebApplication5.Startup))]
namespace TR5_WebApplication5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
