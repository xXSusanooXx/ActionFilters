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
            using (var context = new EfContex())
            {
                context.Exceptions.Add(new DAL.ExceptionDb
                {
                    Message = e.Message,
                    Created = DateTime.Now,
                    Type = e.GetType().ToString()
                });
                context.SaveChanges();
            }
        }
    }
}