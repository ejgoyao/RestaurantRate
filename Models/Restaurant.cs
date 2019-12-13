using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantRate.Models
{
    public class Restaurant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int NumVotes { get; set; }
        public double Rating { get; set; }
        public double AllVotes { get; set; }

    }
}
