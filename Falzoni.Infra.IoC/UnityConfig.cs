using System.Web.Http;
using Unity.WebApi;

namespace Falzoni.Infra.IoC
{
    public class UnityConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var container = UnityModule.LoadModules();

            config.DependencyResolver = new UnityDependencyResolver(container);
        }

    }
}
