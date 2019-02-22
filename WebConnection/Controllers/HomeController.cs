using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebConnection.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Amaya_dbEntities entities = new Amaya_dbEntities();
            return View(from customer in entities.Customers.Take(10)
                        select customer);
        }
    }
}