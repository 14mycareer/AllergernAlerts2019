using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllergenAlertMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace AllergenAlertMVC.ViewModels
{
    public class AddRestaurantViewModel
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Restaurant Name")]
        public string Name { get; set; }

        public string Address { get; set; }


        public string Phone { get; set; }
    }
}
