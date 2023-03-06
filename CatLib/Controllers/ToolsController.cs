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
        public JsonResult CatNameGenerator(string gender, string color, string hair, string[] personality, string[] category)
        {
            var catNames = _context.CatGeneratorNames.Where(x => x.Gender.Name == gender).ToList();
            var colorNames = catNames.Select(x => x.Color.Name == color).ToList();
            var hairNames = catNames.Select(x => x.Hair.Name == hair).ToList();
            var personalityNames = catNames.Where(x => x.CatGeneratorTypes.Any(y => personality.Any(z => z == y.Name))).Select(n => n.Name).ToList();
            var categoryNames = catNames.Where(x => x.CatGeneratorTypes.Any(y => category.Any(z => z == y.Name))).Select(n => n.Name).ToList();

            return Json(catNames);
        }
        public IActionResult DangerousProduct(int id)
        {
            ViewData["Cats"] = _context.News.ToList();
            var dangerousProduct = _context.Products.Include(x => x.ProductCategory).FirstOrDefault(x => x.Id == id);
            return View(dangerousProduct);
        }



        public IActionResult DangerousProductsList()
        {
            var dangerousProductsList = _context.Products.Include(x => x.ProductCategory).ToList();
            return View(dangerousProductsList);
        }

        [HttpGet]
        public IActionResult CalcFood()
        {

            return View();
        }

        [HttpPost]
        public JsonResult CalcFood(int productCal, int catWeight, string weight_type, string type, int times)
        {
            var kCal = ToolServices.CaloriesCalc(catWeight, weight_type, type);
            var foodWeight = ToolServices.CalcFood(productCal, kCal);
            var partional = (double)foodWeight / (double)times;
            return Json(foodWeight, (int)partional);
        }

        [HttpGet]
        public IActionResult CatNamesCategories()
        {
            var categories = _context.CategoryNames.Include(x => x.Personalities).ToList();
            return View(categories);
        }

        [HttpGet]
        public IActionResult SpecificCatNames(int id)
        {
            var specificNemes = _context.Personality.Include(x => x.CatGeneratorNames).
                FirstOrDefault(a => a.Id == id);

            return View(specificNemes);
        }

        public IActionResult DiseasessList(char letter, string search)
        {
            ViewData["Cats"] = _context.News.Take(5).ToList();
            var diseasesList = _context.Diseases.ToList();

            if (!String.IsNullOrEmpty(search))
            {
               diseasesList = _context.Diseases.Where(s => s.Name.Contains(search.ToLower())).ToList();

            }

            if (letter != 0)
            {
                diseasesList = diseasesList.FindAll(x => x.Name.StartsWith(letter));
            }
            return View(diseasesList);
        }

        [HttpGet]
        public IActionResult DiseasesDetail(int id)
        {
            var specificDiseases = _context.Diseases.Include(x => x.Disease_Questions).
                FirstOrDefault(a => a.Id == id);

            return View(specificDiseases);
        }

        [HttpGet]
        public IActionResult MedicationList()
        {
            var diseasesList = _context.Diseases.ToList();

            return View(diseasesList);
        }

        [HttpGet]
        public IActionResult MedicationDetail(int id)
        {
            var specificDiseases = _context.Diseases.Include(x => x.Disease_Questions).
                FirstOrDefault(a => a.Id == id);

            return View(specificDiseases);
        }
    }
}
