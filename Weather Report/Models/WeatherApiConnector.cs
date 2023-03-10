using Newtonsoft.Json;

namespace Weather_Report.Models
{
    public class WeatherApiConnector
    {
        private const string apiKey = "2cb77960-967e-40be-9a8d-f10434bafd9f";
        private readonly Uri forecastUri = new Uri("https://api.weather.yandex.ru/v2/forecast?");
        
        public async Task<WeatherType?> GetWeather(Location location)
        {            
            var weather = JsonConvert.DeserializeObject<WeatherType>(await GetJsonWeather(location) 
                ?? string.Empty);

            return weather;
        }

        private HttpClient CreateWeatherClient(Location location)
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Add("lat", location.Lat.ToString());
            client.DefaultRequestHeaders.Add("lon", location.Long.ToString());
            client.DefaultRequestHeaders.Add("X-Yandex-API-Key", apiKey);

            return client;
        }

        private async Task<string?> GetJsonWeather(Location location)
        {
            var response = await CreateWeatherClient(location).GetAsync(forecastUri);
            
            return await response.Content.ReadAsStringAsync();
        }
    }
}
