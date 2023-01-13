﻿using CatLib.Functionality;
using CatLib.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CatLib.Controllers
{
    public class NewsController : Controller
    {

        private readonly CatLibContext _context;

        public NewsController(CatLibContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
      //  [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(User model)
        {
            if (ModelState.IsValid)
            {
                User user =await _context.Users.FirstOrDefaultAsync(u => u.Name == model.Name && u.Password == model.Password);
                if (user != null)
                {
                  await Authenticate(user);

                    return RedirectToAction("AdminPanel", "News");
                  //  return RedirectToAction("NewsList", "News");
                }
                ModelState.AddModelError("", "wrong password");
            }
            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public IActionResult AdminPanel(News news)
        {
            if (news != null)
            {
                _context.News.Add(news);
                _context.SaveChanges();
            }
         
            return View();
        }


         [HttpGet]
        [Authorize(Roles = "admin")]
       
        // [Authorize(Policy = "admin")]
        // [ValidateAntiForgeryToken]
        public IActionResult AdminPanel()
        {
            return View();
        }

    //    [Authorize(Policy = "admin")]
        public async Task<IActionResult> NewsList(int? pageNumber)
        {
            var news = _context.News.OrderByDescending(x => x.Date).ToList();
             int pageSize = 20;

            return View(await PaginatedList<News>.CreateAsync(news, pageNumber ?? 1, pageSize));
        }

        public IActionResult NewsDetail()
        {
            return View();
        }

        private async Task Authenticate(User user)
        {
           
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Name),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role.ToString())
            };
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType,ClaimsIdentity.DefaultRoleClaimType);
           await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
            //  return new ClaimsIdentity(claims, authenticationType: "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType)
        }
    }
}
