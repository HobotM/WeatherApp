using System.Collections.Generic;
using System.Text.Json.Serialization;
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
