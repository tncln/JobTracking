using JobTracking.Web.CustomFilters;
using JobTracking.Web.Models;
using Microsoft.AspNetCore.Mvc;
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
        [AdAdemOlamaz]
        [HttpPost]
        public IActionResult KayitOl2(KullaniciKayitViewModal model)
        {
            return View();
        }
    }
}
