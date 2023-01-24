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
        public JsonResult CaloriesCalc(int weight, string weight_type, string type)
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
            int ageValue, monthValue, fullAge = 0;
            bool ageNumber = int.TryParse(age, out ageValue);
            bool monthNumber = int.TryParse(month, out monthValue);
            if (ageNumber || monthNumber)
            {
                fullAge = ToolServices.CalcAge(ageValue, monthValue);
            }
            else
                ModelState.AddModelError("age", "Type correct value");

            if (System.Convert.ToInt32(monthValue) > 11)
            {
                ModelState.AddModelError("month", "Type correct months");
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

        [HttpGet]
        public IActionResult CalcFood()
        {
            return View();
        }

        [HttpPost]
        public JsonResult CalcFood(int productCal, int catWeight, string weight_type, string type)
        {
            var kCal = ToolServices.CaloriesCalc(catWeight, weight_type, type);
            var foodWeight= ToolServices.CalcFood(productCal, kCal);
            return Json(foodWeight);
        }
    }
}
