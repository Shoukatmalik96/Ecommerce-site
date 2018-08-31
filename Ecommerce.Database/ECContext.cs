using Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Database
{
    public class ECContext:DbContext
    {
        public ECContext() : base("EcommerceConnectionString")
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Proudcts { get; set; }
    }
}
