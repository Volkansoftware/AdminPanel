﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminPanel.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
      public ActionResult Index2()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            return PartialView();
        }
    }
}