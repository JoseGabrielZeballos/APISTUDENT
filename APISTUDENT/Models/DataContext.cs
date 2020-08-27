using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APISTUDENT.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("Defaultconnection")
        {
                
        }

        public System.Data.Entity.DbSet<APISTUDENT.Models.Student> Students { get; set; }
    }
}