using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        static MySqlConnection db = new MySqlConnection("Server=localhost;Database=imaginecoffee;Uid=root;Password=abc123");
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(Product.AllProducts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult registrationForm()
        {
            return View();
        }

        public IActionResult User()
        {
            return View("User");
        }
        public IActionResult locations()
        {
            return View();
        }

        [HttpPost]
        public IActionResult userAdded(string firstName)
        {
            ViewData["FirstName"] = firstName;
            return View();
        }
        public IActionResult ProductForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product newProduct)
        {
            Product.AllProducts.Add(newProduct);
            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
