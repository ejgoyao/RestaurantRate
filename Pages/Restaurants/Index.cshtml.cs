using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestaurantRate.Data;
using RestaurantRate.Models;

namespace RestaurantRate.Pages.Restaurants
{
    public class IndexModel : PageModel
    {
        private readonly RestaurantRate.Data.RestaurantRateContext _context;

        public IndexModel(RestaurantRate.Data.RestaurantRateContext context)
        {
            _context = context;
        }

        public IList<Restaurant> Restaurant { get;set; }

        public async Task OnGetAsync()
        {
            Restaurant = await _context.Restaurant.ToListAsync();
        }
    }
}
