using System.Text.Json.Serialization;

namespace Entuity.Api.Models.UserDefinedRestPollersData;

public class FilterDefinition
{
	public string FilterType { get; set; } = string.Empty;

	[JsonPropertyName("attrDef")]
	public string AttributeDefinition { get; set; } = string.Empty;

	[JsonPropertyName("attrValue")]
	public required AttributeValue AttributeValue { get; set; }
}