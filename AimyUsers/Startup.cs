using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AimyUsers.Startup))]
namespace AimyUsers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
