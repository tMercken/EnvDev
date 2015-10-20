using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplicationTest1.Models;


namespace WebApplicationTest1.Controllers
{
    public class ForecastController : ApiController
    {
        public CityForecast[] Get()
        {
            CityForecast namurForecast = new CityForecast("namur", 5);
            CityForecast monsForecast = new CityForecast("mons", 5);
            return new CityForecast[] { new CityForecast("namur", 5), new CityForecast("mons", 5) };

            //return (GetForecastFromDatabase());
        }


        private CityForecast[] GetForecastFromDatabase()
        {
            SqlConnection connection = new SqlConnection(@"Data Source = (LocalDb)\MSSQLLocalDb; Initial Catalog = bobLeServeur; Integrated Security = True; Pooling = False");
            SqlCommand cmd = new SqlCommand("SELECT * FROM[Table]", connection);
            connection.Open();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            List<CityForecast> forecasts = new List<CityForecast>();

            while (reader.Read())
            {
                CityForecast forecast = new CityForecast();
                forecast.City = (string)reader["City"];
                forecast.Tempe = (decimal)reader["tempe"];
                forecasts.Add(forecast);
            }
            reader.Close();
            connection.Close();

            return (forecasts.ToArray());
        }
    }
}
   /*
        public String[] Get(String region)
        {
            if (region == "namur")
            {
                return new String[] {"sunny","cloudy","windy" };
            }
            else
            {
                return new String[] {"blabla","frefefe" };
            }
        }

        public String[] Post(String region)
        {
            if (region == "namur")
            {
                return new String[] { "sunny", "cloudy", "windy" };
            }
            else
            {
                return new String[] { "blabla", "frefefe" };
            }
        }*/    
     
