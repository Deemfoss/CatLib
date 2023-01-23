using CatLib.Functionality;
using CatLib.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace CatLib.Controllers
{
    public class NewsController : Controller
    {
        private IHostingEnvironment Environment;
        private readonly CatLibContext _context;

        public NewsController(CatLibContext context, IHostingEnvironment _environment)
        {
            Environment = _environment;
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
                User user = await _context.Users.FirstOrDefaultAsync(u => u.Name == model.Name && u.Password == model.Password);
                if (user != null)
                {
                    await Authenticate(user);

                    return RedirectToAction("AdminPanel", "News");
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

        public async Task<IActionResult> NewsList(int? pageNumber)
        {
            var news = _context.News.OrderByDescending(x => x.Date).ToList();
            int pageSize = 11;
            string type = "pagination";
            return View(PaginatedList<News>.Create(news, pageNumber ?? 1, pageSize, type));
        }

        public async Task<IActionResult> NewsDetail(int id)
        {
            var news = await _context.News.FirstOrDefaultAsync(m => m.Id == id);

            if (news == null)
            {
                return NotFound();
            }
            return View(news);
        }

        private async Task Authenticate(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Name),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role.ToString())
            };
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        [HttpPost]
        public async Task<string> UploadImg(IFormFile file)
        {
            string message;
            string wwwPath = this.Environment.WebRootPath;
            string contentPath = this.Environment.ContentRootPath;
            var saveimg = Path.Combine(wwwPath, "img/news-list-images", file.FileName);
            string imgext = Path.GetExtension(file.FileName);

            if (imgext == ".jpg" || imgext == ".png")
            {
                using (var uploadimg = new System.IO.FileStream(saveimg, FileMode.Create))
                {

                    await file.CopyToAsync(uploadimg);
                    message = "The selected file" + file.FileName + " is save";
                }

            }
            else
            {
                message = "only JPG and PNG extensions are supported";
            }
            return "filename : " + saveimg + " message :" + message;
        }
    }
}
