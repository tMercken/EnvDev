using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationTest1.Models
{
    public class CityForecast
    {
        public string City { get; set; }
        public decimal Tempe { get; set; }

        public CityForecast()
        {        }

        public CityForecast(string c, decimal t)
        {
            City = c;
            Tempe = t;
        }
    }
}