using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(P2.Startup))]
namespace P2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
