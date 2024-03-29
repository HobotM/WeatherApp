using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherApp.Models;
using WeatherApp.ForecastData;
public class WeatherService
{
    private readonly HttpClient _httpClient;

    public WeatherService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

public async Task<WeatherResponse> GetWeather(string city)
{
    var response = await _httpClient.GetAsync($"http://api.openweathermap.org/data/2.5/weather?q={city}&appid=0bb5173502f54f5a0f4f4e2dedb2998a&units=metric");

    if (response.IsSuccessStatusCode)
    {
        using var responseStream = await response.Content.ReadAsStreamAsync();
        var options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = null,
        };
        return await JsonSerializer.DeserializeAsync<WeatherResponse>(responseStream, options);
    }

    throw new HttpRequestException($"Failed to get weather data for city {city}");
}
public async Task<ForecastResponse> GetForecast(string city)
{
    var response = await _httpClient.GetAsync($"http://api.openweathermap.org/data/2.5/forecast?q={city}&appid=0bb5173502f54f5a0f4f4e2dedb2998a&units=metric");

    if (response.IsSuccessStatusCode)
    {
        using var responseStream = await response.Content.ReadAsStreamAsync();
        var options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = null,
        };
        return await JsonSerializer.DeserializeAsync<ForecastResponse>(responseStream, options);
    }

    throw new HttpRequestException($"Failed to get weather data for city {city}");
}


}
