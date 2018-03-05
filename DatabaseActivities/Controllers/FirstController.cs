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

        public ActionResult HorsesToBlocks()
        {
            return View("HorsesToBlocks", model: "");
        }
        [HttpPost]
        public ActionResult ConvertHorses(string type, double number)
        {
            if (type.Equals("horses") || type.Equals("Horses"))
            {
                return View("HorsesToBlocks", model: "Horses = " + number * 33.3333333333);
            }
            else if (type.Equals("blocks") || type.Equals("Blocks"))
            {
                return View("HorsesToBlocks", model: "Blocks = " + number * 0.03);
            }
            else
            {
                return View("UnitConversion", model: "ERROR");
            }
        }
    }



}