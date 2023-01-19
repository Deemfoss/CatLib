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
            _context=context;
        }

        public async Task<IActionResult> Index(int? pageNumber, string search, string sortOrder,string activity,string size, string playfulness, string coat)
        {
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["CurrentFilter"] = search;
            var cats = _context.Cats.ToList();
            FiltrationList filtrationList=new FiltrationList(_context);


            if (!String.IsNullOrEmpty(search))
            {
                cats = _context.Cats.Where(s => s.Name.Contains(search.ToLower())).ToList();
                                       
            }
            switch (sortOrder)
            {
                case "name_desc":
                    cats = cats.OrderByDescending(s => s.Name).ToList();
                    break;
                case "Date":
                    cats = cats.OrderByDescending(s => s.Name).ToList();
                    break;
                case "date_desc":
                    cats = cats.OrderByDescending(s => s.Name).ToList();
                    break;
                default:
                    cats = cats.OrderBy(s => s.Name).ToList();
                    break;
            }

            int pageSize = 20;

            if (!String.IsNullOrEmpty(activity) || !String.IsNullOrEmpty(size) || !String.IsNullOrEmpty(playfulness) || !String.IsNullOrEmpty(coat))
            {
                cats = filtrationList.Filtration(activity, size, playfulness, coat);
            }

              
            
            return View(PaginatedList<Cat>.Create(cats, pageNumber ?? 1, pageSize));
           
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
           
            var cat = await _context.Cats
                .Include(main=>main.MainSpecification)
                .Include(oth=>oth.OtherSpecification)
                .Include(phys=>phys.PhysicalSpecification)
                .Include(tmp => tmp.TemperamentDescription)
                .Include(cmp => cmp.CompatibilityDescription)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (cat == null)
            {
                return NotFound();
            }
            return View(cat);
        }
    }
}
