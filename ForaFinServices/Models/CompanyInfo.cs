// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
using System.Text.Json.Serialization;

namespace ForaFinServices.Models;

public class CompanyInfo
{
    /// <summary>
    /// Updated type to object due to inconsistent source data type. Values were either string or number.
    /// </summary>
    [JsonPropertyName("cik")]
    public object Cik { get; set; }

    [JsonPropertyName("entityName")]
    public string EntityName { get; set; }

    [JsonPropertyName("facts")]
    public Facts Facts { get; set; }
}

