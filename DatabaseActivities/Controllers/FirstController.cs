using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseActivities.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult BaseConversion()
        {
            return View(viewName: "BaseConversion", model: " ");
        }
        [HttpPost]
        public ActionResult BaseConversion(int startNumber)
        {
            return View("BaseConversion", model: "Your number will be: " + Convert.ToString(startNumber, 2));
        }
    }
}