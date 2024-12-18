namespace ForaFinServices.Models
{
    using System.Text.Json.Serialization;

    public class InfoFact
    {
        [JsonPropertyName("us-gaap")]
        public InfoFactUsGaap UsGaap { get; set; }
    }
}
