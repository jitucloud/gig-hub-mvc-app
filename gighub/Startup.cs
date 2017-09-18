using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gig.hub.online.Startup))]
namespace gig.hub.online
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
