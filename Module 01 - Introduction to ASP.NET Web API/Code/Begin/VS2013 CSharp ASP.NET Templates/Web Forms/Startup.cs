using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_Forms.Startup))]
namespace Web_Forms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
