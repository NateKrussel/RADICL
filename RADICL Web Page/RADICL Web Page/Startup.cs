using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RADICL_Web_Page.Startup))]
namespace RADICL_Web_Page
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
