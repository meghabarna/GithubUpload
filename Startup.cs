using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHubTestProject.Startup))]
namespace GitHubTestProject
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
