using System.Text.Json;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.IpamData.Get;

public class IpamSettingsAndStatusResponseConverter
	: JsonConverter<IpamSettingsAndStatusResponse>
{
	public override IpamSettingsAndStatusResponse Read(
		ref Utf8JsonReader reader,
		Type typeToConvert,
		JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartArray)
			throw new JsonException("Expected StartArray token");

		// Read first element: array of strings
		reader.Read();
		var statuses = JsonSerializer.Deserialize<List<string>>(ref reader, options)
			?? throw new JsonException("Could not get statuses");

		// Read second element: ApiSettings object
		reader.Read();
		var settings = JsonSerializer.Deserialize<IpamSettings>(ref reader, options)
			?? throw new JsonException("Could not get settings");

		// Confirm end of array
		reader.Read();
		if (reader.TokenType != JsonTokenType.EndArray)
			throw new JsonException("Expected EndArray token");

		return new IpamSettingsAndStatusResponse
		{
			Statuses = statuses,
			Settings = settings
		};
	}

	public override void Write(
		Utf8JsonWriter writer,
		IpamSettingsAndStatusResponse value,
		JsonSerializerOptions options)
	{
		writer.WriteStartArray();
		JsonSerializer.Serialize(writer, value.Statuses, options);
		JsonSerializer.Serialize(writer, value.Settings, options);
		writer.WriteEndArray();
	}
}
