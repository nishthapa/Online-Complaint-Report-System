using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OCRS.Startup))]
namespace OCRS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
