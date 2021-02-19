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
        // GET: Products/Random
        public ActionResult Random()
        {

            var product = new Product() { Name = "Vela cumpleaños 3" };

            var customers = new List<Customer>
            { 
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomProductViewModel
            {
                Product = product,
                Customers = customers
            };

            return View(viewModel);
        }
    }
}