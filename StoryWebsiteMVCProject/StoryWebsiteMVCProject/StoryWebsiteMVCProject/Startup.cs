using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StoryWebsiteMVCProject.Startup))]
namespace StoryWebsiteMVCProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
