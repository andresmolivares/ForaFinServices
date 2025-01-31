using System.Text.Json.Serialization;

namespace ForaFinServices.Models;

public class FinancialResource
{
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("units")]
    public Units? Units { get; set; }
}