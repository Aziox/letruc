using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agenga.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult addCustomer()
        {
            return View();
        }
        public ActionResult listCustomers()
        {
            return View();
        }
    }
}