using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.BLL;

namespace MvcApplication2.Filters
{
    public class MyOwnActionAndResultFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Logger logger = new Logger();
            var text = new LogTextCreator().PrepareHttpResponse(context.HttpContext.Response);
            logger.Write(text);
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Logger logger = new Logger();
            var text = new LogTextCreator().PrepareHttpRequest(context.HttpContext.Request);
            logger.Write(text);
        }
    }
}