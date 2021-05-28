using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using CoffeeShop.Models;
using MySql.Data.MySqlClient;

namespace CoffeeShop.Controllers
{
    public class ProductController1 : Controller
    {
        static MySqlConnection db = new MySqlConnection("Server=localhost;Database=imaginecoffee;Uid=root;Password=abc123");
        public IActionResult Index()
        {
            List<Product> prod = db.GetAll<Product>().ToList();
            return View(prod);
        }
        public IActionResult Detail(string id)
        {
            Product prod = db.Get<Product>(id);
            return Content(prod.Name);
        }
    }
}
