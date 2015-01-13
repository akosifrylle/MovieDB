using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using MovieDB.Web.App_Start;

namespace MovieDB.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AutoMapperConfig.Initialize();
            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
 
        }
    }
}
