using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrowdLuminary.Startup))]
namespace CrowdLuminary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
