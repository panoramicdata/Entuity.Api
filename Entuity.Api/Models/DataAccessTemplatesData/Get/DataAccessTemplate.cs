using Entuity.Api.Enums;
using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.DataAccessTemplatesData.Get;
public class DataAccessTemplate : IGetItem
{
	public string Name { get; set; } = string.Empty;

	[JsonPropertyName("$type")]
	public required TemplateType Type { get; set; }
	public string Description { get; set; } = string.Empty;
}
