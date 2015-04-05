using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WRole.Startup))]
namespace WRole
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
