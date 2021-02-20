using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YuShop.Models;
using YuShop.ViewModels;

namespace YuShop.Controllers
{
    public class CustomersController : Controller
    {

        private MyDbContext _context;

        public CustomersController()
        {
            _context = new MyDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
            // añade la entidad foranea a nuestra entidad customer para mostrar su data
            var customers = _context.Costumers.Include(c => c.membershipType).ToList();

            var viewModel = new CustomersViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {

            var customer = _context.Costumers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View("Details", customer);
        }

    }
}