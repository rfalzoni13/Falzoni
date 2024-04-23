using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web;
using Falzoni.Presentation.Administrator.Clients.Interfaces.Register;
using Falzoni.Utils.Helpers;

namespace Falzoni.Presentation.Administrator.Attributes
{
    public class UserRegisterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            IRoleClient roleClient = DependencyResolver.Current.GetService(typeof(IRoleClient)) as IRoleClient;

            if (HttpContext.Current.GetOwinContext().Authentication.User.Identity.IsAuthenticated)
            {
                if (filterContext.Controller.ViewBag.Perfis == null)
                    filterContext.Controller.ViewBag.Perfis = Task.Run(async () => await roleClient.GetAllAsync(UrlConfigurationHelper.RoleGetAll)).Result;
            }

            base.OnActionExecuting(filterContext);
        }
    }
}