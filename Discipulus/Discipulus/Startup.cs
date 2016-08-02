using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Discipulus.Startup))]
namespace Discipulus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
