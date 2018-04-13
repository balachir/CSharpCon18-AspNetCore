using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcApp_NetFramework.Startup))]
namespace MvcApp_NetFramework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
