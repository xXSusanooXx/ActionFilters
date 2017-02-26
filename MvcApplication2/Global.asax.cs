using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using MvcApplication2.BLL;
using MvcApplication2.Filters;

namespace MvcApplication2
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            //GlobalFilters.Filters.Add(new MyExceptionFilter());
            //GlobalFilters.Filters.Add(new MyOwnActionAndResultFilter());
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        /*protected void Application_Error(object sender, EventArgs e)
        {
            new Exceptions().Add(Server.GetLastError());
        }
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            Console.Write("Bu");
        }
        protected void Application_EndRequest(object sender, EventArgs e)
        {
            Console.Write("Ba");
        }*/
    }
}