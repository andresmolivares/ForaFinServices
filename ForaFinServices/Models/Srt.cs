// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
using System.Text.Json.Serialization;

namespace ForaFinServices.Models;

public class Srt
{
    [JsonPropertyName("StockRepurchaseProgramAuthorizedAmount")]
    public StockRepurchaseProgramAuthorizedAmount StockRepurchaseProgramAuthorizedAmount { get; set; }
}

