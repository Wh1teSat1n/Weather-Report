using Newtonsoft.Json;

namespace Weather_Report.Models
{
    public class WeatherType
    {
        [JsonProperty("now_dt")]
        public string? Date { get; set; }
        [JsonProperty("info")]
        public Location? Location { get; set; }
        [JsonProperty("fact")]
        public Fact? Fact { get; set; } 
    }
    public class Fact
    {
        [JsonProperty("temp")]
        public int? Temp { get; set; }
        [JsonProperty("condition")]
        public string? Condition { get; set; }
        [JsonProperty("wind_speed")]
        public int? WindSpeed  { get; set; }
        [JsonProperty("pressure_mm")]
        public int? Pressure { get; set; }
    }
}
