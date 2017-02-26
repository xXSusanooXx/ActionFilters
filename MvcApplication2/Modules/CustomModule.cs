using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplication2.BLL;

namespace MvcApplication2.Modules
{
    public class CustomModule : IHttpModule
    {
        public CustomModule()
        {
        }

        public String ModuleName
        {
            get { return "HelloWorldModule"; }
        }

        public void Init(HttpApplication application)
        {
            application.BeginRequest +=
                (new EventHandler(this.Application_BeginRequest));
            application.EndRequest +=
                (new EventHandler(this.Application_EndRequest));
            application.Error += 
                (new EventHandler(this.Application_Error));
        }

        private void Application_BeginRequest(Object source,
             EventArgs e)
        {
            HttpApplication application = (HttpApplication)source;
            HttpContext context = application.Context;
            var text = new LogTextCreator().PrepareHttpRequest(context.Request);
            new Logger().Write(text);
        }

        private void Application_EndRequest(Object source, EventArgs e)
        {
            HttpApplication application = (HttpApplication)source;
            HttpContext context = application.Context;
            
            var text = new LogTextCreator().PrepareHttpResponse(context.Response);
            new Logger().Write(text);
        }

        private void Application_Error(object source, EventArgs e)
        {
            HttpApplication application = (HttpApplication)source;
            new Exceptions().Add(application.Server.GetLastError());
        }

        public void Dispose() { }
    }
}