using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllergenAlertMVC.Data
{
    public class RestaurantDbContext : DbContext

    {
        public DbSet<Restaurant>Restaurants { get; set; }
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext>options)
            :base(options)
        {

        }
    }
}
