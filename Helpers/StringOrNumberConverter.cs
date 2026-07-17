using System.Text.Json;
using System.Text.Json.Serialization;

namespace RegistrarManagement.Helpers;

public class StringOrNumberConverter : JsonConverter<string>
{
    public override string Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            return reader.GetString() ?? string.Empty;
        }

        if (reader.TokenType == JsonTokenType.Number)
        {
            int number = reader.GetInt32();

            return number switch
            {
                1 => "1st Year",
                2 => "2nd Year",
                3 => "3rd Year",
                4 => "4th Year",
                _ => number.ToString()
            };
        }

        if (reader.TokenType == JsonTokenType.Null)
        {
            return string.Empty;
        }

        throw new JsonException(
            $"Cannot convert {reader.TokenType} to a string.");
    }

    public override void Write(
        Utf8JsonWriter writer,
        string value,
        JsonSerializerOptions options)
    {
        writer.WriteStringValue(value);
    }
}