using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DomMezonin.Startup))]
namespace DomMezonin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
