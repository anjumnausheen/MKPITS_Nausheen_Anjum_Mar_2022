using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Program3_ASP.Startup))]
namespace Program3_ASP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
