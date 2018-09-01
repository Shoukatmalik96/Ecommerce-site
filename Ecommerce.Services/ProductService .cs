using Ecommerce.Database;
using Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services
{
    public class ProdutService
    {

        public Product GetProduct(int ID)
        {
            using (var context = new ECContext())
            {
               return context.Proudcts.Find(ID);
               
            }
        }

        public List<Product> GetProducts()
        {
            using (var context = new ECContext())
            {
                return context.Proudcts.ToList();

            }
        }
        public void SaveProduct(Product product)
        {
            using (var context = new ECContext())
            {
                context.Proudcts.Add(product);
                context.SaveChanges();
            }
        }
        public void UpdateProduct(Product product)
        {
            using (var context = new ECContext())
            {
                context.Entry(product).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteProduct(Product product)
        {
            using (var context = new ECContext())
            {
                context.Entry(product).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}
