using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ClothingSizeClient.Models;

namespace ClothingSizeClient.Controllers
{
  public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
//api/Brands/xs
// [HttpGet {"{xs}"]
// public async Task <ActionResult<IEnumerable<Brand>>> GetXS ()
// {
//     var query = _db.Brands.AsQueryable(); 
//     query =query.OrderByDescending(brand => brand.XS)
//     return await query.ToListAsync (); 
// }

//api/Brands/gap
// [HttpGet ("{name}")]
// public async Task <ActionResult<IEnumerable<Brand>>> GetName ()
// {
//     var query = _db.Brands.AsQueryable(); 
//     query =query.OrderByDescending(brand => brand.Name)
//     return await query.ToListAsync (); 
// }
