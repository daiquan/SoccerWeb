using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SoccerWeb.Startup))]
namespace SoccerWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
