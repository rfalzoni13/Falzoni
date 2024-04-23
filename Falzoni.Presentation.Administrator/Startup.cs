using Falzoni.Utils.Helpers;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

[assembly: OwinStartup(typeof(Falzoni.Presentation.Administrator.Startup))]

namespace Falzoni.Presentation.Administrator
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions()
            {
                AuthenticationType = "ApplicationCookie",
                LoginPath = new PathString("/Account/Login")
            });

            UrlConfigurationHelper.SetUrlList();
        }
    }
}
