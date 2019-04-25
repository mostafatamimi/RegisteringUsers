using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RegisteringUsers.Startup))]
namespace RegisteringUsers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
