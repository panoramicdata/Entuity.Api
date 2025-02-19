using Entuity.Api.Enums;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models;
public class DataAccessTemplate
{
	public string Name { get; set; } = string.Empty;

	[JsonPropertyName("$type")]
	public required TemplateType Type { get; set; }
	public string Description { get; set; } = string.Empty;
}
