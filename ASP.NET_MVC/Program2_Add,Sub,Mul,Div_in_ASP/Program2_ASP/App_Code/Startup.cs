using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Program2_ASP.Startup))]
namespace Program2_ASP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
