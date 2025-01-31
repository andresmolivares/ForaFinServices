using System.Text.Json.Serialization;
using System.Text.Json;

namespace ForaFinServices.DataModel.Converters;

public class CikConverter : JsonConverter<string>
{
    public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return reader.TokenType switch
        {
            JsonTokenType.String => reader.GetString()!,
            JsonTokenType.Number => reader.GetInt64().ToString(), // Convert number to string
            _ => throw new JsonException("Invalid CIK format")
        };
    }

    public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value);
    }
}