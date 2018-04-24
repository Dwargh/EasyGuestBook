using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EZGB.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Index","Post", new { area ="App" });
        }

        public ActionResult Error(string message)
        {
            return View(message);
        }
    }
}
