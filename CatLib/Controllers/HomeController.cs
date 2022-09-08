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

        public async Task<IActionResult> Index( bool hueta)
        {
            return View(await _context.Cats.ToListAsync());
        }

        public async Task<IActionResult> Filter(bool hueta)
        {
            var res = hueta;
            return View(await _context.Cats.ToListAsync());
        }

        public async Task<IActionResult> News()
        {
            return View(await _context.Cats.ToListAsync());
        }

        public async Task<IActionResult> CatDetail(int id)

        {

            var cat = await _context.Cats.Include(a=>a.MainSpecification).
                FirstOrDefaultAsync(m => m.Id == id);

            if (cat == null)
            {
                return NotFound();
            }
            return View(cat);
        }
    }
}
