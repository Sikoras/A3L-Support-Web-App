using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(A3LBackend.Startup))]
namespace A3LBackend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
