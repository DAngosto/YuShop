using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YuShop.Models;

namespace YuShop.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products/Random
        public ActionResult Random()
        {

            var product = new Product() { Name = "Vela cumpleaños 3" };

            return View(product);
        }
    }
}