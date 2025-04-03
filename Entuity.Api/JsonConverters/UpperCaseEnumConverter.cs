using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Entuity.Api.JsonConverters;

public class UpperCaseEnumConverter<T> : JsonConverter<T> where T : struct, Enum
{
	public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var value = reader.GetString();
		if (Enum.TryParse(value, true, out T result))
		{
			return result;
		}

		throw new JsonException($"Unable to convert \"{value}\" to {typeof(T)}.");
	}

	public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
	{
		string enumValue = GetEnumMemberValue(value) ?? value.ToString().ToUpper();
		writer.WriteStringValue(enumValue);
	}

	private static string? GetEnumMemberValue(T value)
	{
		return typeof(T)
			.GetField(value.ToString())?
			.GetCustomAttribute<EnumMemberAttribute>()?
			.Value;
	}
}
