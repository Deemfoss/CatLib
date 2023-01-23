using CatLib.Models;
using CatLib.Models.NameGenerator;
using CatLib.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatLib.Controllers
{
    public class ToolsController : Controller
    {
        private readonly CatLibContext _context;

        public ToolsController(CatLibContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult CalorieCalc()
        {
            return View();
        }

        [HttpPost]
        public JsonResult CaloriesCalc(string weight, string weight_type, string type)
        {
            var ckcal = ToolServices.CaloriesCalc(weight, weight_type, type);
            return Json(ckcal);
        }

        [HttpGet]
        public IActionResult CalcAge()
        {
            return View();
        }

        [HttpPost]
        public JsonResult CalcAge(string age, string month)
        {

            if (System.Convert.ToInt32(month) > 11)
            {
                ModelState.AddModelError("month", "Type correct months");
            }

            int ages = System.Convert.ToInt32(age);
            int months = System.Convert.ToInt32(month);
            int fullAge = 0;

            if (ages == 1)
            {
                fullAge = 15;
                return Json(fullAge);
            }
            if (ages == 2)
            {
                fullAge = 24;
                return Json(fullAge);
            }

            var middleAges = 0;
            int oldAges = 0;

            if (ages > 2)
            {
                for (int i = 0; i < ages; i++)
                {
                    if (i > 2 && i < 16)
                    {
                        middleAges++;

                    }

                    if (i >= 16)
                    {
                        oldAges++;
                    }

                }

                middleAges = (middleAges + 1) * 4;
                oldAges = oldAges * 3;


                if (months > 0)
                {
                    months = Convert.ToInt32(months * 1.3);
                }

                fullAge = middleAges + oldAges + 24 + months;
            }

            if (ages == 0 && months > 0)
            {
                if (months <= 1)
                {
                    fullAge = 1;
                }

                if (months == 2)
                {
                    fullAge = 2;
                }

                if (months > 2)
                {
                    fullAge = System.Convert.ToInt32(months * 1.6);
                }

            }
            return Json(fullAge);
        }

        [HttpGet]
        public IActionResult CatNameGenerator()
        {

            return View();
        }

        [HttpPost]
        public JsonResult CatNameGenerator(string gender, string color, string hair, string personality, string[] category)
        {
            var catNames = _context.CatGeneratorNames.Where(x => x.Gender.Name == gender && x.Color.Name == color && x.Hair.Name == hair && x.Personality.Name == personality);
            var test = catNames.Where(x => x.CatGeneratorTypes.Any(y => category.Any(z => z == y.Name))).Select(n => n.Name);
            return Json(test);
        }
        public IActionResult DangerousProducts()
        {
            var dangerousProducts = _context.Products.Include(x => x.ProductCategory).ToList();
            return View(dangerousProducts);
        }


    }
}
