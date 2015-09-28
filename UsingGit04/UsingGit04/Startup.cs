using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UsingGit04.Startup))]
namespace UsingGit04
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
