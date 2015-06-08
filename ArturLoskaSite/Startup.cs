using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArturLoskaSite.Startup))]
namespace ArturLoskaSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
