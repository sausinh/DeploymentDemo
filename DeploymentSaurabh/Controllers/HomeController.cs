﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeploymentSaurabh.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page - Github Deployment.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page - Github Deployment.";

            return View();
        }
    }
}