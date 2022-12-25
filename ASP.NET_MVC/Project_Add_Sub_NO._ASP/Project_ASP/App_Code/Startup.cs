using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project_ASP.Startup))]
namespace Project_ASP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
