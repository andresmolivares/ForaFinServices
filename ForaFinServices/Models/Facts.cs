// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
using System.Text.Json.Serialization;

namespace ForaFinServices.Models;

public class Facts
{
    [JsonPropertyName("dei")]
    public Dei Dei { get; set; }

    [JsonPropertyName("us-gaap")]
    public UsGaap UsGaap { get; set; }

    [JsonPropertyName("srt")]
    public Srt Srt { get; set; }
}

