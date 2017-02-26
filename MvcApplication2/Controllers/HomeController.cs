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
        
        public ActionResult Index()
        {
            int b = 0;
            var c = 3 / b;
            return View();
        }

        //Итак, из моих наблюдейний, обработка идет в следующем порядке. 
        //1) Срабатывают обработчики из HttpModule 
        //2) Срабатывают обработчики из GlobalAsax
        //3) Срабатывают фильтры
        
        //А это значит то, что метод init iHttpModule выполняется раньше, чем добавление методов из Global.asax
    }
}
