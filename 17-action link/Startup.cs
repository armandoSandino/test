using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_17_action_link.Startup))]
namespace _17_action_link
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
