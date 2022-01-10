using JobTracking.Business.Interfaces;
using JobTracking.Entity.Concrete;
using JobTracking.UI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTracking.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GorevController : Controller
    {
        private readonly IGorevService _gorevService;
        private readonly IAciliyetService _aciliyetService;
        public GorevController(IGorevService gorevService, IAciliyetService aciliyetService)
        {
            _gorevService = gorevService;
            _aciliyetService = aciliyetService;
        }
        public IActionResult Index()
        {
            TempData["Active"] = "gorev";
            List<Gorev> gorevler = _gorevService.GetirAciliyetIleTamamlanmayan();
            List<GorevListViewModel> models = new List<GorevListViewModel>();
            foreach (var item in gorevler)
            {
                GorevListViewModel model = new GorevListViewModel()
                {
                    Aciklama = item.Aciklama,
                    OlusturmaTarihi = item.OlusturulmaTarihi,
                    Aciliyet = item.Aciliyet,
                    AciliyetId = item.AciliyetId,
                    Ad = item.Ad,
                    Durum = item.Durum,
                    Id = item.Id
                };
                models.Add(model);
            }

            return View(models);
        }
        public IActionResult EkleGorev()
        {
            TempData["Active"] = "gorev"; 
            ViewBag.Aciliyetler = new SelectList(_aciliyetService.Getirhepsi(),"Id","Tanim");
            return View(new GorevAddViewModel());
        }
        [HttpPost]
        public IActionResult EkleGorev(GorevAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                _gorevService.Kaydet(new Gorev
                {
                    Ad = model.Ad,
                    AciliyetId = model.AciliyetId,
                    Aciklama=model.Aciklama
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
