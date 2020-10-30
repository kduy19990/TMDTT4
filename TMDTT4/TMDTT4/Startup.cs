using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TMDTT4.Startup))]
namespace TMDTT4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
