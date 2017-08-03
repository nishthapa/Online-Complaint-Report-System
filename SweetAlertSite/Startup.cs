using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SweetAlertSite.Startup))]
namespace SweetAlertSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
