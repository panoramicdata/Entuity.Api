using System.Text.Json.Serialization;

namespace Entuity.Api.Models.UserDefinedRestPollersData;

/// <summary>
/// Determines which of the applicable objects the poller will actually be applied to. Can be omitted or left null to apply to all of them
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838639545373-User-Defined-REST-Pollers-RESTful-API#post'/></para>
/// </summary>
public class FilterDefinition
{
	public string FilterType { get; set; } = string.Empty;

	[JsonPropertyName("attrDef")]
	public string AttributeDefinition { get; set; } = string.Empty;

	[JsonPropertyName("attrValue")]
	public required AttributeValue AttributeValue { get; set; }
}