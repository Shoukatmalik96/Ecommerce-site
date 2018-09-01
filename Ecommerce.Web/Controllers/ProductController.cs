using Ecommerce.Entities;
using Ecommerce.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce.Web.Controllers
{
    public class ProductController : Controller
    {

        ProdutService productService = new ProdutService();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductTable(string search)
        {
            var products = productService.GetProducts();

            if (string.IsNullOrEmpty(search) == false)
            {
                products = products.Where(x => x.Name != null && x.Name.ToLower().Contains(search.ToLower())).ToList();

            }
            return PartialView(products);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            productService.SaveProduct(product);
            return RedirectToAction("ProductTable");
        }
        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var category = productService.GetProduct(ID);
            return View(category);
        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            productService.UpdateProduct(product);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int ID)
        {
            var category = productService.GetProduct(ID);
            return View(category);
        }
        [HttpPost]
        public ActionResult Delete(Product product)
        {
            productService.DeleteProduct(product);
            return RedirectToAction("Index");
        }
    }
}