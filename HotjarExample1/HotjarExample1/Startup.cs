using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HotjarExample1.Startup))]
namespace HotjarExample1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
