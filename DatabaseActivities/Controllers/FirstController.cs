﻿using System;
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
    }
}