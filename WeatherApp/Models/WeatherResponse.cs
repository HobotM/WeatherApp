using System.Collections.Generic;
using System.Text.Json.Serialization;
public class WeatherResponse
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("main")]
    public Main Main { get; set; }
    [JsonPropertyName("weather")]
    public List<Weather> Weather { get; set; }
    [JsonPropertyName("wind")]
    public Wind Wind { get; set; }
    [JsonPropertyName("sys")]
    public Sys Sys {get;set;}
    [JsonPropertyName("timezone")]
    public int Timezone { get; set; }
}

public class Main
{
    [JsonPropertyName("temp")]
    public double Temp { get; set; }
    [JsonPropertyName("pressure")]
    public int Pressure { get; set; }
    [JsonPropertyName("humidity")]
    public int Humidity { get; set; }
    [JsonPropertyName("temp_min")]
    public double TempMin { get; set; }
    [JsonPropertyName("temp_max")]
    public double TempMax { get; set; }
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
}

public class Wind
{
    [JsonPropertyName("speed")]
    public double Speed { get; set; }
    [JsonPropertyName("deg")]
    public int Deg { get; set; }
}

public class Sys
{
    [JsonPropertyName("sunrise")]
    public long Sunrise { get; set; }

    [JsonPropertyName("sunset")]
    public long Sunset { get; set; }
}