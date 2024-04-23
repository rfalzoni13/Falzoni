using Falzoni.Application.IdentityConfiguration;
using Falzoni.Infra.IoC;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(Falzoni.Presentation.Api.Startup))]

namespace Falzoni.Presentation.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //Register configurations
            HttpConfiguration config = new HttpConfiguration();

            //GlobalConfiguration.Configure(WebApiConfig.Register);
            WebApiConfig.Register(config);

            //Injeção de dependência
            UnityConfig.Register(config);

            //Configure Owin            
            AppBuilderConfiguration.ConfigureAuth(app);
            app.UseCors(CorsOptions.AllowAll);
            AppBuilderConfiguration.ActivateAccessToken(app);

            app.UseWebApi(config);
            //AppBuilderConfiguration.ConfigureCors(app);
        }
    }
}
