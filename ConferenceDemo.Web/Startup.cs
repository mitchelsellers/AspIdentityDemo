using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConferenceDemo.Web.Startup))]
namespace ConferenceDemo.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
