using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NFFightSim.Startup))]
namespace NFFightSim
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
