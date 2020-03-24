using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StoryBeeHiveWebsite.Startup))]
namespace StoryBeeHiveWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
