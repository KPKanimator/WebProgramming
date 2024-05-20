using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_02_WebApplicationMVC.Startup))]
namespace _02_WebApplicationMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
