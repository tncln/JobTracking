using JobTracking.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTracking.UI.Controllers
{
    public class HomeController : Controller
    {
        IGorevService _gorevService;
        public HomeController(IGorevService gorevService)
        {
            _gorevService = gorevService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
