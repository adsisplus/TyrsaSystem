using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Adsisplus.Cotyrsa.WebSite.Startup))]
namespace Adsisplus.Cotyrsa.WebSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
