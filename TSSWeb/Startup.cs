using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TSSWeb.Startup))]
namespace TSSWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
