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
using CatLib.Models.Product_Reviews;

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


        public async Task<IActionResult> BestProductsList()
        {
            var news = _context.News.OrderByDescending(x => x.Date).ToList();
            int pageSize = 11;
            string type = "pagination";
            return View();
        }
        public async Task<IActionResult> BestProductDetail()
        {
            var news = _context.News.OrderByDescending(x => x.Date).ToList();
            int pageSize = 11;
            string type = "pagination";
            return View();
        }

    }

}
