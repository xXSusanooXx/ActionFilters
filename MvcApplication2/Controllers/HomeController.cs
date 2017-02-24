using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Filters;

namespace MvcApplication2.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Hone/
        [MyExceptionFilter]
        [MyOwnActionAndResultFilter]
        public ActionResult Index()
        {
            int b = 0;
            var c = 3 / b;
            return View();
        }
    }
}
