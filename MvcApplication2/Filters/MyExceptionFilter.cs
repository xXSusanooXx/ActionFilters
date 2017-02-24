using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.BLL;

namespace MvcApplication2.Filters
{
    public class MyExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (!context.ExceptionHandled)
            {
                new Exceptions().Add(context.Exception);
            }
            else
            {
                Console.WriteLine("Handled!");
            }
            context.ExceptionHandled = true;
        }
    }
}