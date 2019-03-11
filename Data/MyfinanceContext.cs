using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class MyfinanceContext : System.Data.Entity.DbContext
    {

        public MyfinanceContext() : base("Name=Alias")
        {

        }
        //proprieté de connection db sets
        public System.Data.Entity.DbSet<Product> Products { get; set; }
        public System.Data.Entity.DbSet<Category> Categories { get; set; }
        public System.Data.Entity.DbSet<Provider> Providers { get; set; }
    }
}
