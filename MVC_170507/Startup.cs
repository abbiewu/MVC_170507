using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_170507.Startup))]
namespace MVC_170507
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
