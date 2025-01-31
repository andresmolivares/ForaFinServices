using System.Text.Json.Serialization;

namespace ForaFinServices.Models;

public class Srt
{
    [JsonPropertyName("StockRepurchaseProgramAuthorizedAmount")]
    public FinancialResource? StockRepurchaseProgramAuthorizedAmount { get; set; }
}

