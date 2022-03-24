using BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TM2Multitier.Controllers
{
    public class CustomerController : Controller
    {
        private CustomerBL customerBL;
        public CustomerController()
        {
            customerBL = new CustomerBL();
        }
        public IActionResult Index()
        {
            var customer = customerBL.GetCustomer();
            return View(customer);
        }
    }
}
