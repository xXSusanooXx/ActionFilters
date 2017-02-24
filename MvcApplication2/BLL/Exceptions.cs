using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplication2.DAL;
using System.Data.Entity.Validation;

namespace MvcApplication2.BLL
{
    public class Exceptions
    {
        public void Add(Exception e)
        {
            using (var context = new ActionFiltersEntities())
            {
                context.Exceptions.Add(new DAL.Exceptions()
                {
                    Id = context.Exceptions.OrderByDescending(ex=>ex.Id).FirstOrDefault().Id + 1,
                    Message = e.Message,
                    Created = DateTime.Now,
                    Type = e.GetType().ToString()
                });
                context.SaveChanges();
            }
        }
    }
}