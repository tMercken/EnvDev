using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Forecast
    {
        public string City { get; set; }
        public decimal Tempe { get; set; }

        public Forecast()
        { }

        public Forecast(string c, decimal t)
        {
            City = c;
            Tempe = t;
        }

        public String ToString()
        {
            return this.City;
        }
    }
}
