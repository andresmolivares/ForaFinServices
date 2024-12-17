namespace ForaFinServices.Models
{
    using System.Text.Json.Serialization;

    public class InfoFact
    {
        [JsonPropertyName("us-gaap")]
        public required InfoFactUsGaap UsGaap { get; set; }
    }
}
