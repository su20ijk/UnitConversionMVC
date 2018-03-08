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

        public ActionResult HorseToBlocks()
        {
            return View("HorseToBlocks", model: "");
        }
        [HttpPost]
        public ActionResult ConvertHorses(string type, double number)
        {
            if (type.Equals("horses") || type.Equals("Horses"))
            {
                return View("HorseToBlocks", model: "Blocks = " + number * 0.03);
            }
            else if (type.Equals("blocks") || type.Equals("Blocks"))
            {
                return View("HorseToBlocks", model: "Horses = " + number * 33.333333333333333333333333333333);
            }
            else
            {
                return View("UnitConversion", model: "ERROR");
            }
        }
    }



        public ActionResult PoundsToKilos()
        {
            return View("PoundsToKilos", model: "");
        }
        [HttpPost]
        public ActionResult ConvertPounds(string weight, double number)
        {
            if (weight.Equals("kilograms"))
            {
                return View("PoundsToKilos", model: "Pounds = " + number * 2.20462);
            }
            else if (weight.Equals("pounds"))
            {
                return View("PoundsToKilos", model: "Kilograms = " + number * 0.453592);
            }
            else
            {
                return View("UnitConverison", model: "ERROR");
            }
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

        public ActionResult MetersToFeet()
         {
        return View("MetersToFeet", model: "");
         }

    [HttpPost]
    public ActionResult MetersToFeet(double inputNumber)
    {
        return View("MetersToFeet", model: "Feet: " + inputNumber * 3.21);
    }
    }
}