using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Skylakias.Startup))]
namespace Skylakias
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
