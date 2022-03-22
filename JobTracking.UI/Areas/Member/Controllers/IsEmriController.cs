﻿using JobTracking.Business.Interfaces;
using JobTracking.Entity.Concrete;
using JobTracking.UI.Areas.Admin.Models;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<AppUser> _userManager;
        private readonly IRaporService _raporService;
        public IsEmriController(IGorevService gorevService, UserManager<AppUser> userManager, IRaporService raporService)
        {
            _gorevService = gorevService;
            _userManager = userManager;
            _raporService = raporService;
        }
        public async Task<IActionResult> Index()
        {
            TempData["Active"] = "isemri";

            var user= await _userManager.FindByNameAsync(User.Identity.Name);

            var gorevler= _gorevService.GetirTumTablolarla(I => I.AppUserId == user.Id && !I.Durum);
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
        public IActionResult EkleRapor(int id)
        {
            RaporAddViewModel model = new RaporAddViewModel();
            model.GorevId = id;
            return View();
        }
    }
}
