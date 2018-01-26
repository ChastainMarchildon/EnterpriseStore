using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EnterpriseProject.Startup))]
namespace EnterpriseProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
