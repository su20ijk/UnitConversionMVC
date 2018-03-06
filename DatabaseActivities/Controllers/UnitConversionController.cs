using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseActivities.Controllers
{
    public class UnitConversionController : Controller
    {
        // GET: UnitConversion
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GramToOunce()
        {
            return View("GramToOunce", "");
        }

        [HttpPost]
        public ActionResult GramToOunce(double Grams)
        {
            return View(viewName: "GramToOunce", model: "Ounces: " + Grams * 0.035274);
        }
    }
}