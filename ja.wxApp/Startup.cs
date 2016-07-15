using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ja.wxApp.Startup))]
namespace ja.wxApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
