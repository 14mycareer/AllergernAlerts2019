using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace allergen app project.Controllers
{
    public class PickAllergenController : Controller
    {
        // GET: /<controller>/

        //Action method for displaying "Pick Allergen" page 
        public IActionResult Index()
        {

        //Retrieve allergens for a drop down list
        var allergens = GetAllAllergens();

        var model = new PickAllergen();


        //Make a list of SelectListItems to be rendered on the page
        model.Allergens = GetSelectListItem(allergens);
            return View(model);
        }
    }
}
