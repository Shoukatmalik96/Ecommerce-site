using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities
{
   public class Category:BaseEntity
    {
        List<Product> products { get; set; }
        public string ImageUrl { get; set; }
    }
}
