using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamComeback.Startup))]
namespace TeamComeback
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
