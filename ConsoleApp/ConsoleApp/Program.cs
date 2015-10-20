using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CallWebApiAsync();
            Console.ReadKey();
        }

        static async Task CallWebApiAsync()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://bobtheapp.azurewebsites.net/api/forecast");
            var json = await response.Content.ReadAsStringAsync();

            var forecasts = Newtonsoft.Json.JsonConvert.DeserializeObject<Forecast[]>(json);
            foreach( var forecast in forecasts)
            {
                Console.Write(forecast.ToString());
                Console.ReadKey();
            }
                //Newtonsoft.Json.JsonConvert.DeserializeObject<forecast>;

        }
    }
}


