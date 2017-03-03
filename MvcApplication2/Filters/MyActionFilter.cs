using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.BLL;
using log4net;

namespace MvcApplication2.Filters
{
    public class MyOwnActionAndResultFilter : ActionFilterAttribute
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            //Logger logger = new Logger();
            //logger.Write(text);
            var text = new LogTextCreator().PrepareHttpResponse(context.HttpContext.Response);
            log.Info(text);
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //Logger logger = new Logger();
            //logger.Write(text);
            var text = new LogTextCreator().PrepareHttpRequest(context.HttpContext.Request);
            log.Info(text);
        }
    }
}