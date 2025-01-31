using System.Text.Json.Serialization;

namespace ForaFinServices.Models;

public class Dei
{
    [JsonPropertyName("EntityCommonStockSharesOutstanding")]
    public FinancialResource? EntityCommonStockSharesOutstanding { get; set; }

    [JsonPropertyName("EntityNumberOfEmployees")]
    public FinancialResource? EntityNumberOfEmployees { get; set; }

    [JsonPropertyName("EntityPublicFloat")]
    public FinancialResource? EntityPublicFloat { get; set; }
}

