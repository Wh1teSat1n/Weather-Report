using Newtonsoft.Json;
using System.Globalization;

namespace Weather_Report.Models
{
    public class Location
    {
        [JsonProperty("url")]
        private string? urlPlace;
        [JsonProperty("lat")]
        public decimal? Lat { get; private set; }
        [JsonProperty("lon")]
        public decimal? Long { get; private set; }
        //[JsonIgnore]
        public string? Place { get; private set; }

        public Location(decimal _lat, decimal _long)
        {
            Lat = _lat;
            Long = _long;
            Place = parseUrlPlace(urlPlace);
        }
            
        private string? parseUrlPlace(string? url)
        {
            string? place = url?.Substring(url.IndexOf("pogoda/") + 7, url.IndexOf("?"));
            var textInfo = new CultureInfo("ru-RU").TextInfo;

            return textInfo.ToTitleCase(place ?? string.Empty);
        }
    }
}
