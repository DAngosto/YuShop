using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YuShop.Models;

namespace YuShop.ViewModels
{
    public class CustomersViewModel
    {

        public IEnumerable<Customer> Customers { get; set; }

    }
}