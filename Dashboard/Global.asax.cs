using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Dashboard.Controllers;
using DryIoc;
using DryIoc.Mvc;

namespace Dashboard
{
	public class Global : HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			RouteConfig.RegisterRoutes(RouteTable.Routes);

			var container = new Container();
			container.Register<IService, Service>();
			container.Register<IContext, Context>();

			container.WithMvc();
		}
	}
}
