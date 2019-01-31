using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agenga.Models;

namespace Agenga.Controllers
{
    public class BrokerController : Controller
    {
        [HttpPost]
        public ActionResult addBroker()
        {
            return View();
        }
        public ActionResult listBrokers()
        {
            return View();
        }
    }
}