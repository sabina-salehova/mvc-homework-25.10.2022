using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_homework_25._10._2022.DAL;
using mvc_homework_25._10._2022.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_homework_25._10._2022.Controllers
{
    public class HomeController : Controller
    {
        readonly AppDbContext _dbContext;
        public HomeController(AppDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var products = _dbContext?.Products?.ToList();
            //var brands = new List<Brand>
            //{
            //    new Brand{ id=1, name="Zara"},
            //    new Brand{ id=2, name="Puma"},
            //    new Brand{ id=3, name="KALINI"},
            //};

            //var products = new List<Product>
            //{ 
            //    new Product{ id=1, title="T-shirt", category=Category.Tshirt, brand=brands[0], color=Colors.Black, description="Finding perfect t-shirt", gender=Gender.Children, price=55, image="cloth_1.jpg"},
            //    new Product{ id=2, title="Corater", category=Category.Shoes, brand=brands[0], color=Colors.Black, description="Finding perfect t-shirt", gender=Gender.Children, price=65, image="cloth_2.jpg"},
            //    new Product{ id=3, title="Polo Shirt", category=Category.PoloShirt, brand=brands[0], color=Colors.Black, description="Finding perfect t-shirt", gender=Gender.Children, price=12, image="cloth_3.jpg"},
            //    new Product{ id=4, title="T-shirt", category=Category.Tshirt, brand=brands[0], color=Colors.Black, description="Finding perfect t-shirt", gender=Gender.Children, price=55, image="cloth_1.jpg"},
            //    new Product{ id=5, title="Corater", category=Category.Shoes, brand=brands[0], color=Colors.Black, description="Finding perfect t-shirt", gender=Gender.Children, price=65, image="cloth_2.jpg"},
            //    new Product{ id=6, title="Polo Shirt", category=Category.PoloShirt, brand=brands[0], color=Colors.Black, description="Finding perfect t-shirt", gender=Gender.Children, price=12, image="cloth_3.jpg"},
            //};

            HomeViewModel hvm = new HomeViewModel { products=products};

            return View(hvm);
        }
    }
}
