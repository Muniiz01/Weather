using System.Text.Json;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Clima.Pages
{
    public class IndexModel : PageModel
    {
        private readonly HttpClient _httpClient;
        public WeatherData? Weather { get; set; }
        public IndexModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        

        public async Task OnGetAsync(string city = "London")
        {
            if(string.IsNullOrEmpty(city))
            {
                Weather = null;
                return;
            }
            string apikey = "YOUR-API-KEY-HERE";
            string url = $"http://api.weatherapi.com/v1/current.json?key={apikey}&q={city}&aqi=no";

            var response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {

                var json = await response.Content.ReadAsStringAsync();
                var weatherResponse = JsonSerializer.Deserialize<JsonElement>(json);

                Weather = new WeatherData
                {
                    City = weatherResponse.GetProperty("location").GetProperty("name").GetString(),
                    Description = weatherResponse.GetProperty("current").GetProperty("condition").GetProperty("text").GetString(),
                    Temperature = ((int)weatherResponse.GetProperty("current").GetProperty("temp_c").GetDouble()),
                    Icon = weatherResponse.GetProperty("current").GetProperty("condition").GetProperty("icon").GetString(),
                    uv = weatherResponse.GetProperty("current").GetProperty("uv").GetDouble(),
                    WindKph = ((int)weatherResponse.GetProperty("current").GetProperty("wind_kph").GetDouble()),
                    Humidity = weatherResponse.GetProperty("current").GetProperty("humidity").GetInt32(),
                    PressureMb = ((int)weatherResponse.GetProperty("current").GetProperty("pressure_mb").GetDouble()),
                    Thermal = ((int)weatherResponse.GetProperty("current").GetProperty("feelslike_c").GetDouble()),
                    Visibility = ((int)weatherResponse.GetProperty("current").GetProperty("vis_km").GetDouble())

                };

            }else
            {
                Console.WriteLine($"Erro na API: {response.StatusCode}");
            }

        }

    }
}
