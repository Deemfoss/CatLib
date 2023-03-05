using CatLib.Functionality;
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
            _context = context;
        }

        public async Task<IActionResult> Index(int? pageNumber, string search, string sortOrder, string activity, string size, string playfulness, string coat)
        {
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["SheddingSortParm"] = sortOrder == "shedding" ? "shedding_desc" : "shedding";
            ViewData["ActivitySortParm"] = sortOrder == "activity" ? "activity_desc" : "activity";
            ViewData["CurrentFilter"] = search;
            var cats = _context.Cats.ToList();
            FiltrationList filtrationList = new FiltrationList(_context);


            if (!String.IsNullOrEmpty(search))
            {
                cats = _context.Cats.Where(s => s.Name.Contains(search.ToLower())).ToList();

            }
            switch (sortOrder)
            {
                case "name_desc":
                    cats = cats.OrderByDescending(s => s.Name).ToList();
                    break;
                case "shedding_desc":
                    cats = cats.OrderByDescending(s => s.Shedding).ToList();
                    break;
                case "shedding":
                    cats = cats.OrderBy(s => s.Shedding).ToList();
                    break;
                case "activity_desc":
                    cats = cats.OrderByDescending(s => s.Activity).ToList();
                    break;
                case "activity":
                    cats = cats.OrderBy(s => s.Activity).ToList();
                    break;
                default:
                    cats = cats.OrderBy(s => s.Name).ToList();
                    break;
            }

            int pageSize = 3;
            string type = "load";

            if (!String.IsNullOrEmpty(activity) || !String.IsNullOrEmpty(size) || !String.IsNullOrEmpty(playfulness) || !String.IsNullOrEmpty(coat))
            {
                cats = filtrationList.Filtration(activity, size, playfulness, coat);
            }

            return View(PaginatedList<Cat>.Create(cats, pageNumber ?? 1, pageSize, type));

        }

        public PartialViewResult Filter()
        {

            return PartialView("FilterPartal");
        }

        public async Task<IActionResult> News()
        {
            return View(await _context.Cats.ToListAsync());
        }

        public async Task<IActionResult> CatDetail(int id)
        {

            // ViewData["Cats"] = _context.Cats.ToList();

            ViewData["Cats"] = _context.News.ToList();

            var cat = await _context.Cats
                .Include(main => main.MainSpecification)
                .Include(oth => oth.OtherSpecification)
                .Include(phys => phys.PhysicalSpecification)
                .Include(tmp => tmp.TemperamentDescription)
                .Include(cmp => cmp.CompatibilityDescription)
                .Include(quest => quest.Answers).ThenInclude(q => q.Question)
                .FirstOrDefaultAsync(m => m.Id == id);

                    if (cat == null)
            {
                return NotFound();
            }
            return View(cat);
        }
    }
}
