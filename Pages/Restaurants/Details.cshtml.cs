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
    public class DetailsModel : PageModel
    {
        private readonly RestaurantRate.Data.RestaurantRateContext _context;

        public DetailsModel(RestaurantRate.Data.RestaurantRateContext context)
        {
            _context = context;
        }

        public Restaurant Restaurant { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Restaurant = await _context.Restaurant.FirstOrDefaultAsync(m => m.ID == id);

            if (Restaurant == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
