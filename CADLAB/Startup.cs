using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CADLAB.Startup))]
namespace CADLAB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
