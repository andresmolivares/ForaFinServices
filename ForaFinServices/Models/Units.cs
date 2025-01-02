// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
using System.Text.Json.Serialization;

namespace ForaFinServices.Models;

public class Units
{
    [JsonPropertyName("shares")]
    public List<Share>? Shares { get; set; }

    [JsonPropertyName("USD")]
    public List<USD>? USD { get; set; }

    [JsonPropertyName("pure")]
    public List<Pure>? Pure { get; set; }

    [JsonPropertyName("USD/shares")]
    public List<USDShare>? USDShares { get; set; }

    [JsonPropertyName("Employee")]
    public List<Employee>? Employee { get; set; }

    [JsonPropertyName("Y")]
    public List<Y>? Y { get; set; }

    [JsonPropertyName("lawsuit")]
    public List<Lawsuit>? Lawsuit { get; set; }

    [JsonPropertyName("plaintiff")]
    public List<Plaintiff>? Plaintiff { get; set; }

    [JsonPropertyName("patent")]
    public List<Patent>? Patent { get; set; }

    [JsonPropertyName("segment")] //NOTE: Alternative attribute: segement
    public List<Segment>? Segment { get; set; }

    [JsonPropertyName("reportingUnit")] //NOTE: Alternative attribute: reporting_unit
    public List<ReportingUnit>? ReportingUnit { get; set; }

    [JsonPropertyName("derivative_agreement")]
    public List<DerivativeAgreement>? DerivativeAgreement { get; set; }
}

