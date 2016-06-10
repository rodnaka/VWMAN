using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VWMAN.Startup))]
namespace VWMAN
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
