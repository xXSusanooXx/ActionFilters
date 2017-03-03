using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcApplication2.DAL
{
    public class EfContex : DbContext
    {
        public EfContex(): base("LogDatabase")
        {
        }
        public DbSet<ExceptionDb> Exceptions { get; set; }
    }
}