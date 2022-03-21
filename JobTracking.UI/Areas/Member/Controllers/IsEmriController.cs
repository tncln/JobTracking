using JobTracking.Business.Interfaces;
using JobTracking.UI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTracking.UI.Areas.Member.Controllers
{
    [Area("Member")]
    public class IsEmriController : Controller
    {
        private readonly IGorevService _gorevService;
        public IsEmriController(IGorevService gorevService)
        {
            _gorevService = gorevService;
        }
        public IActionResult Index(int id)
        {
            TempData["Active"] = "isemri";
            var gorevler= _gorevService.GetirTumTablolarla(I => I.AppUserId == id&&!I.Durum);
           List< GorevListAllViewModel> models = new List<GorevListAllViewModel>();

            foreach (var item in gorevler)
            {
                GorevListAllViewModel model = new GorevListAllViewModel();
                model.Id = item.Id;
                model.Aciklama = item.Aciklama;
                model.Aciliyet = item.Aciliyet;
                model.Ad = item.Ad;
                model.AppUser = item.AppUser;
                model.Raporlar = item.Raporlar;
                model.OlusturmaTarihi = item.OlusturulmaTarihi;
                models.Add(model);
            }
            return View(models);
        }
    }
}
