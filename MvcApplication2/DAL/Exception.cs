using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace MvcApplication2.DAL
{
    public class ExceptionDb
    {
        public int Id { get; set; }
        [Column("ExceptionMessage")] 
        public string Message { get; set; }
        public DateTime Created { get; set; }
        public string Type { get; set; }
    }
}