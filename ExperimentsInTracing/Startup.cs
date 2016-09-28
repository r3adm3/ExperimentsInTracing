using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExperimentsInTracing.Startup))]
namespace ExperimentsInTracing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
