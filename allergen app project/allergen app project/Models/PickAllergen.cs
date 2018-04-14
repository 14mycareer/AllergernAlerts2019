using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace allergen app project.Models
{
    public class PickAllergen
    {
    //This property will reserve space for the allergen selected by the usser
    [Required]
    [Display(Name="Allergen")]
    public string Allergen { get; set; }

    //This property will hold the allergens available for the user to choose
    public IEnumerable<SelectListItem> Allergens { get; set; }
    }
}
