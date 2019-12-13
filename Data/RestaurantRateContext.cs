using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestaurantRate.Models;

namespace RestaurantRate.Data
{
    public class RestaurantRateContext : DbContext
    {
        public RestaurantRateContext (DbContextOptions<RestaurantRateContext> options)
            : base(options)
        {
        }

        public DbSet<RestaurantRate.Models.Restaurant> Restaurant { get; set; }
    }
}
