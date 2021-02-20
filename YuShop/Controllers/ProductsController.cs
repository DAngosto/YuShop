using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YuShop.Models;
using YuShop.ViewModels;

namespace YuShop.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {

            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Shrek" },
                new Product { Id = 2, Name = "Wall-e" }
            };

            var viewModel = new ProductsViewModel
            {
                Products = products
            };

            return View(viewModel);
        }

    }
}