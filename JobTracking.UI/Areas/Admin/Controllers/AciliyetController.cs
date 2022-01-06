using JobTracking.Business.Interfaces;
using JobTracking.Entity.Concrete;
using JobTracking.UI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTracking.UI.Areas.Admin
{
    [Area("Admin")]
    public class AciliyetController : Controller
    {
        private readonly IAciliyetService _aciliyetService;
        public AciliyetController(IAciliyetService aciliyetService)
        {
            _aciliyetService = aciliyetService;
        }
        public IActionResult Index()
        {
            List<Aciliyet> aciliyetler= _aciliyetService.Getirhepsi();

            List<AciliyetListViewModel> model = new List<AciliyetListViewModel>();
            foreach (var item in aciliyetler)
            {
                AciliyetListViewModel aciliyetModel = new AciliyetListViewModel();
                aciliyetModel.Id = item.Id;
                aciliyetModel.Tanim = item.Tanim;
                model.Add(aciliyetModel);
            }
            return View(model);
        }
        public IActionResult EkleAciliyet()
        {
            return View(new AciliyetAddViewModel());
        }
        [HttpPost]
        public IActionResult EkleAciliyet(AciliyetAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                _aciliyetService.Kaydet(new Aciliyet() {
                Tanim=model.Tanim
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
