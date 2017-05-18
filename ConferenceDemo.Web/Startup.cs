using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConferenceDemo.Web.Startup))]
namespace ConferenceDemo.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            //NOTE Order is VERY important here
            var config = new HttpConfiguration();
            ConfigureAuth(app);

            app.UseWebApi(config);
        }
    }
}
