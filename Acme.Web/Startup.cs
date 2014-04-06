using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Acme.Web.Startup))]
namespace Acme.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
