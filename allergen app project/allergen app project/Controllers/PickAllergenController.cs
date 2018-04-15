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
    public IActionResult PickAllergenChoice()

    {

        //Retrieve allergens for a drop down list
        var allergens = GetAllAllergens();

        var model = new PickAllergen();


        //Make a list of SelectListItems to be rendered on the page
        model.Allergens = GetSelectListItem(allergens);
        return View(model);
    }

    //Method for accepting user entered data when "submit" button is pressed 
  [HttpPost]
  public IActionResult PickAllergenChoice(PickAllergen model)

    {
        //Get list of all allergens again
        var allergens = GetAllAllergens();

        //Set the allergens on the model. This is done because only the selected value from drop dow is posted back but we want all of them.
        model.Allergens = GetSelectListItems(allergens);
}
}

    //Returns a list of allergens. Future plans will make source a database
    private IEnumerable<string> GetAllAllergens()
{
    return new List<string>
    {
        "Nuts",
        "Milk/Dairy",
        "Soy",
        "Shellfish",

    };
}
//Redirect to completed selection page


//Method takes a list of strings & returns a list of SelectListItem objects which will be used to render the drop down list.
private IEnumerable<SelectListItem> GetSelectListItems(IEnumerable<string> elements)
{
    //Create empty list to hold result
    var selectList = new List<SelectListItem>();

    //For each string of 'element' variable creates a new SelectListItem object that helps to render each item as:
    //<option value="Allergen">Allergen</option>
    foreach (var element in elements)
    {
        selectList.Add(new SelectListItem
        {
            ValueTask = element,
            Text = element
        });
    }
    return selectList;


}
    
}

