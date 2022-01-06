using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTracking.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GorevController1 : Controller
    {
       
        public IActionResult Index()
        {
            TempData["Active"] = "gorev";
            return View();
        }
    }
}
