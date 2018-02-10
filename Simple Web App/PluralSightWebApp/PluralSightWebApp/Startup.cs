using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PluralSightWebApp.Startup))]
namespace PluralSightWebApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
