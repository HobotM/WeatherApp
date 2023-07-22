using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherApp.Models;

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

    return null;
}


}
