using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AllergenAlertMVC.Models;
using AllergenAlertMVC.Data;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AllergenAlertMVC.Controllers
{
    public class RestaurantController : Controller
    {

        //define database to which to attach restaurant objects
        private RestaurantDbContext context;

        //database constructor
        public RestaurantController(RestaurantDbContext dbContext)
        {
            context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            //need to fix to display listing of restaurants; change c=>c.Category
            //IList<Restaurant> restaurants = context.Restaurants.Include(c => c.Category).ToList();

            IList<Restaurant> restaurants = context.Restaurants.ToList();

            return View(restaurants);
        }

        public IActionResult Add()
        {

            return View();
            //AddRestaurantViewModel addRestaurantViewModel = new AddRestaurantViewModel(context.Restaurants.ToList());
            //return View(addRestaurantViewModel);
        }

        [HttpPost]
        [Route("/Restaurant/Add")]
        public IActionResult NewRestaurant(string name, string address, int pho
            ne)
        {
            Restaurant newRestaurant = new Restaurant
            { Name = name, Address = address,
                Phone = phone
            };
            Restaurant.Add(newRestaurant);

            return Redirect("/Restaurant");

        }
    }
       
}
