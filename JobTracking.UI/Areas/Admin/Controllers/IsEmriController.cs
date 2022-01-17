using JobTracking.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTracking.UI.Areas.Admin.Controllers
{
    public class IsEmriController : Controller
    {
        private readonly IAppUserService _appUserService;
        public IsEmriController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }
        public IActionResult Index()
        {
            TempData["Active"] = "isemri";
            var model = _appUserService.GetNotAdmin();
            return View(model);
        }
    }
}
