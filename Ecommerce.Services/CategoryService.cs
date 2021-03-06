﻿using Ecommerce.Database;
using Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services
{
    public class CategoryService
    {

        public Category GetCategory(int ID)
        {
            using (var context = new ECContext())
            {
               return context.Categories.Find(ID);
               
            }
        }

        public List<Category> GetCategories()
        {
            using (var context = new ECContext())
            {
                return context.Categories.ToList();

            }
        }
        public void SaveCategory(Category category)
        {
            using (var context = new ECContext())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }
        public void UpdateCategory(Category category)
        {
            using (var context = new ECContext())
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteCategory(Category category)
        {
            using (var context = new ECContext())
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}
