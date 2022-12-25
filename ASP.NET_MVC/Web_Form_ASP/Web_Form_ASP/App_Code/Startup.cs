using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_Form_ASP.Startup))]
namespace Web_Form_ASP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
