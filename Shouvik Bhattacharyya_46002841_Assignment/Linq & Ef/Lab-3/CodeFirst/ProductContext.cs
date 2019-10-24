using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace UsingCodeFirst
{
    class ProductContext:DbContext
    {
        public ProductContext()
            :base("ConProduct")
        {
            Database.SetInitializer<ProductContext>(new CreateDatabaseIfNotExists<ProductContext>());
        }

        public DbSet<Product> Products { get; set; }
    }
}
