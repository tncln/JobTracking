﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTracking.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult KayitOl()
        {
            return View();
        }
        [HttpPost]
        public IActionResult KayitOl2()
        {
            return View();
        }
    }
}
