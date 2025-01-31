using ForaFinServices.DataModel.Converters;
using System.Text.Json.Serialization;

namespace ForaFinServices.DataModel;

public class CikItem
{
    [JsonConverter(typeof(CikConverter))]
    public string Key { get; set; }

    public string Name { get; set; }

    public string Data { get; set; }
}

