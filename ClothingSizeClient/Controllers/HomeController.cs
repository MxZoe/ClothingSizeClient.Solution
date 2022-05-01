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

        public ActionResult Index(string search)
        {

            if (search != null)
            {
                var allQueries = ApiHelper.GetUserInput(search).Result.ToString();
                return View("Index", allQueries);
            }
            else
            {
                return View();
            }
            // if (searchBy == "Name")
            // {
            // return View(_db.Book.Where(x => x.Name.Contains(search) || search == null).ToList());
            // }
            // else
            // {
            // List<Book> model = _db.Book.ToList();
            // return View(model);
        }
        

        // public IActionResult Index()
        // {
        //     return RedirectToAction("Index", "Home");
        // }
        // public IActionResult Index(string userInput)
        // {
        //     var allQueries = ApiResponse.GetWhatever(userInput);
        //     return View(allQueries);
        // }



       // public IActionResult Privacy()
     //   {
      //      return View();
      //  }

       // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
         //   return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}



