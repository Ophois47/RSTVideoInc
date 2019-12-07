using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RSTVideoInc.Startup))]
namespace RSTVideoInc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
