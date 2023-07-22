using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherApp.Models;

public class WeatherService
{
    private readonly HttpClient _http;

    public WeatherService(HttpClient http)
    {
        _http = http;
    }

    public async Task<WeatherResponse> GetWeatherAsync(string city)
    {
        var response = await _http.GetStringAsync($"http://api.openweathermap.org/data/2.5/weather?q={city}&appid=0bb5173502f54f5a0f4f4e2dedb2998a&units=metric");
        return JsonSerializer.Deserialize<WeatherResponse>(response);
    }
}
