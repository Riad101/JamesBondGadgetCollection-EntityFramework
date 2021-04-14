using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JamesBondGadgetsEntity.Startup))]
namespace JamesBondGadgetsEntity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
