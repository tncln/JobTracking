﻿using JobTracking.Web.CustomFilters;
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
        public void SetCookie()
        {
            HttpContext.Response.Cookies.Append("kisi", "Adem", new Microsoft.AspNetCore.Http.CookieOptions() {
             Expires=DateTime.Now.AddDays(20),
             HttpOnly=true,//Javascript e karşı kapatmış oluruz XSS açıklarına karşı koruma
             SameSite=Microsoft.AspNetCore.Http.SameSiteMode.Strict //İlgili web sayfası görebilir  
            });
        }
        public string GetCookie()
        {
            return HttpContext.Request.Cookies["kisi"];
        }
    }
}
