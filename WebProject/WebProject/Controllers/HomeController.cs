﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Request.IsAuthenticated)
            {
                return View("Search");
            }
            else {
                return View();
            }
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
        public ActionResult Search()
        {
            ViewBag.Message = "Search Engine";

            return View();
        }
        public ActionResult Notes()
        {
            ViewBag.Message = "Notes";

            return View();
        }
        public ActionResult Money()
        {
            ViewBag.Message = "Money";

            return View();
        }
    }
}