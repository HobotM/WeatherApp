using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace WeatherApp.ForecastData
{
    public class ForecastResponse
    {
        [JsonPropertyName("list")]
        public List<Forecast> List { get; set; }
    }

    public class Forecast
    {
        [JsonPropertyName("dt")]
        public long Dt { get; set; }
        [JsonPropertyName("main")]
        public Main Main { get; set; }
        [JsonPropertyName("weather")]
        public List<Weather> Weather { get; set; }
        [JsonPropertyName("wind")]
        public Wind Wind { get; set; }
    }

    public class Weather
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("main")]
        public string Main { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        public string GetIconUrl(long dt, long sunrise, long sunset)
        {

            // Compare the adjusted timestamps
            string dayOrNight = dt >= sunrise && dt < sunset ? "d" : "n";
            switch (Id)
            {
                case int n when (n >= 200 && n < 300):
                    return $"/icons/11{dayOrNight}.svg"; // Thunderstorm
                case int n when (n >= 300 && n < 400):
                    return $"/icons/09{dayOrNight}.svg"; // Drizzle
                case int n when (n >= 500 && n < 600):
                    return $"/icons/10{dayOrNight}.svg"; // Rain
                case int n when (n == 511):
                    return $"/icons/13{dayOrNight}.svg"; // Freezing rain
                case int n when (n >= 600 && n < 700):
                    return $"/icons/13{dayOrNight}.svg"; // Snow
                case int n when (n >= 700 && n < 800):
                    return $"/icons/50{dayOrNight}.svg"; // Atmosphere
                case int n when (n == 800):
                    return $"/icons/01{dayOrNight}.svg"; // Clear sky
                case int n when (n == 801):
                    return $"/icons/02{dayOrNight}.svg"; // Few clouds
                case int n when (n == 802):
                    return $"/icons/03{dayOrNight}.svg"; // Scattered clouds
                case int n when (n >= 803 && n <= 804):
                    return $"/icons/04{dayOrNight}.svg"; // Broken clouds to overcast clouds
                default:
                    return $"/icons/default.svg";
            }
        }

    }

}