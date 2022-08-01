using CatLib.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CatLib.Controllers
{
    public class HomeController : Controller
    {
        private readonly CatLibContext _context;

        public HomeController(CatLibContext context)
        {
            _context=context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Cats.ToListAsync());
        }
    }
}
