﻿using JobTracking.Entity.Concrete;
using JobTracking.UI.Areas.Admin.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTracking.UI.Areas.Admin.ViewComponents
{
    public class Wrapper:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        public Wrapper(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IViewComponentResult Invoke()
        {
           var user= _userManager.FindByNameAsync(User.Identity.Name).Result;
            AppUserListViewModel model = new AppUserListViewModel();
            model.Id = user.Id;
            model.Name = user.Name;
            model.Picture = user.Picture;
            model.SurName = user.Picture;
            model.Email = user.Email;
            return View(model);
        }
    }
}
