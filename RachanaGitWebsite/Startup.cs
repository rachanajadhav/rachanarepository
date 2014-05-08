using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RachanaGitWebsite.Startup))]
namespace RachanaGitWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
