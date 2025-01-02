// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
using System.Text.Json.Serialization;

namespace ForaFinServices.Models;

public class Dei
{
    [JsonPropertyName("EntityCommonStockSharesOutstanding")]
    public EntityCommonStockSharesOutstanding EntityCommonStockSharesOutstanding { get; set; }

    [JsonPropertyName("EntityNumberOfEmployees")]
    public EntityNumberOfEmployees EntityNumberOfEmployees { get; set; }

    [JsonPropertyName("EntityPublicFloat")]
    public EntityPublicFloat EntityPublicFloat { get; set; }
}

