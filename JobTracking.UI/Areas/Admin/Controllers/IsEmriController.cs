﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTracking.UI.Areas.Admin.Controllers
{
    public class IsEmriController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
