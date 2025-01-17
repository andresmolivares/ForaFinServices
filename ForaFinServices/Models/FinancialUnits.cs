// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
using System.Text.Json.Serialization;

namespace ForaFinServices.Models;

public class BaseFinancialUnit
{
    [JsonPropertyName("end")]
    public string? End { get; set; }

    [JsonPropertyName("val")]
    public decimal Val { get; set; }

    [JsonPropertyName("accn")]
    public string? Accn { get; set; }

    [JsonPropertyName("fy")]
    public int? Fy { get; set; }

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

public class DerivativeAgreement : BaseFinancialUnit;

public class Employee : BaseFinancialUnit;

public class Lawsuit : BaseFinancialUnit;

public class Patent : BaseFinancialUnit;

public class Plaintiff : BaseFinancialUnit;

public class Pure : BaseFinancialUnit;

public class ReportingUnit : BaseFinancialUnit;

public class Segment : BaseFinancialUnit;

public class Share : BaseFinancialUnit;

public class USD : BaseFinancialUnit;

public class USDShare : BaseFinancialUnit;

public class Y : BaseFinancialUnit;
