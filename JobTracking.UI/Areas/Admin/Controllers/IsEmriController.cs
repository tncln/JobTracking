﻿using JobTracking.Business.Interfaces;
using JobTracking.Entity.Concrete;
using JobTracking.UI.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTracking.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class IsEmriController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IGorevService _gorevService;
        public IsEmriController(IAppUserService appUserService, IGorevService gorevService)
        {
            _appUserService = appUserService;
            _gorevService = gorevService;
        }
        public IActionResult Index()
        {
            TempData["Active"] = "isemri";
            //var model = _appUserService.GetNotAdmin();
            List<Gorev> gorevler= _gorevService.GetirTumTablolarla();
            List<GorevListAllViewModel> models = new List<GorevListAllViewModel>();

            foreach (var item in gorevler)
            {
                GorevListAllViewModel model = new GorevListAllViewModel();
                model.Id = item.Id;
                model.Aciklama = item.Aciklama;
                model.Aciliyet = item.Aciliyet;
                model.Ad = item.Ad;
                model.AppUser = item.AppUser;
                model.OlusturmaTarihi = item.OlusturulmaTarihi;
                model.Raporlar = item.Raporlar;
                models.Add(model);
            }
            return View(models);
        }

        public IActionResult AtaPersonel(int id,string s,int sayfa=1)
        {
            TempData["Active"] = "isemri";
            ViewBag.AktifSayfa = sayfa;
            //ViewBag.ToplamSayfa = (int)Math.Ceiling((double)_appUserService.GetNotAdmin().Count / 3);
            int toplamSaya;

            var gorev = _gorevService.GetirAciliyetIdile(id);
                      

            var personeller = _appUserService.GetNotAdmin(out toplamSaya, s,sayfa);

            ViewBag.ToplamSayfa = toplamSaya;

            List<AppUserListViewModel> appUserListModel = new List<AppUserListViewModel>();
            foreach (var item in personeller)
            {
                AppUserListViewModel model = new AppUserListViewModel();
                model.Id = item.Id;
                model.Name = item.Name;
                model.SurName = item.Surname;
                model.Email = item.Email;
                model.Picture = item.Picture;
                appUserListModel.Add(model);
            }

            ViewBag.Personeller = personeller;

            GorevListViewModel gorevModel = new GorevListViewModel();
            gorevModel.Id = gorev.Id;
            gorevModel.Ad = gorev.Ad;
            gorevModel.Aciklama = gorev.Aciklama;
            gorevModel.Aciliyet = gorev.Aciliyet;
            gorevModel.OlusturmaTarihi = gorev.OlusturulmaTarihi;
            return View(gorevModel);
        }
    }
}
