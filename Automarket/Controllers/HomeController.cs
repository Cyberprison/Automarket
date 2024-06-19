using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Automarket.Domain.Entity;

namespace Automarket.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Car car = new Car()
            {
                Name = "",
                Speed = ""
            };
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}