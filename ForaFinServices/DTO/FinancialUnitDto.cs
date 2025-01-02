using System.Text.Json.Serialization;

namespace ForaFinServices.DTO
{
    public class FinancialUnitDto
{
    [JsonPropertyName("end")]
    public string? End { get; set; }

    [JsonPropertyName("val")]
    public decimal Val { get; set; }

    [JsonPropertyName("accn")]
    public string? Accn { get; set; }

    [JsonPropertyName("fy")]
    public int Fy { get; set; }

    [JsonPropertyName("fp")]
    public string? Fp { get; set; }

    [JsonPropertyName("form")]
    public string? Form { get; set; }

    [JsonPropertyName("filed")]
    public string? Filed { get; set; }

    [JsonPropertyName("frame")]
    public string? Frame { get; set; }

    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

}
