using System.Text.Json.Serialization;

namespace ForaFinServices.Models;

public class Units
{
    [JsonPropertyName("shares")]
    public List<FinancialUnit>? Shares { get; set; }

    [JsonPropertyName("USD")]
    public List<FinancialUnit>? USD { get; set; }

    [JsonPropertyName("pure")]
    public List<FinancialUnit>? Pure { get; set; }

    [JsonPropertyName("USD/shares")]
    public List<FinancialUnit>? USDShares { get; set; }

    [JsonPropertyName("Employee")]
    public List<FinancialUnit>? Employee { get; set; }

    [JsonPropertyName("Y")]
    public List<FinancialUnit>? Y { get; set; }

    [JsonPropertyName("lawsuit")]
    public List<FinancialUnit>? Lawsuit { get; set; }

    [JsonPropertyName("plaintiff")]
    public List<FinancialUnit>? Plaintiff { get; set; }

    [JsonPropertyName("patent")]
    public List<FinancialUnit>? Patent { get; set; }

    [JsonPropertyName("segment")] //NOTE: Alternative attribute: segement
    public List<FinancialUnit>? Segment { get; set; }

    [JsonPropertyName("reportingUnit")] //NOTE: Alternative attribute: reporting_unit
    public List<FinancialUnit>? ReportingUnit { get; set; }

    [JsonPropertyName("derivative_agreement")]
    public List<FinancialUnit>? DerivativeAgreement { get; set; }
}

