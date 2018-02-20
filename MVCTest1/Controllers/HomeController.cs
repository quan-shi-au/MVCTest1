﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(string id)
        {
            switch (id)
            {
                case "yahoo":
                    return Redirect("http://www.yahoo.com/");
                case "google":
                    return Redirect("http://www.google.com/");
                default:
                    return View();
            }
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}