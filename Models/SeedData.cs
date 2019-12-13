using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RestaurantRate.Data;
using System;
using System.Linq;

namespace RestaurantRate.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RestaurantRateContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RestaurantRateContext>>()))
            {
                // Look for any restaurants.
                if (context.Restaurant.Any())
                {
                    return;   // DB has been seeded
                }

                context.Restaurant.AddRange(
                    new Restaurant
                    {
                        Name = "Paddy's Pub",
                        Type = "Pub",
                        NumVotes = 1,
                        Rating = 5,
                        AllVotes = 5
                    },

                    new Restaurant
                    {
                        Name = "Krusty Krab",
                        Type = "Fast Food",
                        NumVotes = 0,
                        Rating = 0,
                        AllVotes = 0
                    },
                    new Restaurant
                    {
                        Name = "Central Perk",
                        Type = "Coffee Shop",
                        NumVotes = 0,
                        Rating = 0,
                        AllVotes = 0
                    },
                    new Restaurant
                    {
                        Name = "Krusty Burger",
                        Type = "Fast Food",
                        NumVotes = 0,
                        Rating = 0,
                        AllVotes = 0
                    },
                    new Restaurant
                    {
                        Name = "Mos Eisley Cantina",
                        Type = "Pub",
                        NumVotes = 0,
                        Rating = 0,
                        AllVotes = 0
                    }
                );
                context.SaveChanges();
            }
        }
    }
}