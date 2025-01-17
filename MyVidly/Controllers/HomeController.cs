﻿using MyVidly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyVidly.Controllers
{
    //[AllowAnonymous]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.IsInRole(RoleName.CanManageMovies))
                return View("AdminView");

            return View("CustomerView");
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