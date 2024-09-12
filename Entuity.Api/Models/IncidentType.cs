using System.Text.Json.Serialization;

namespace Entuity.Api.Models;

public class IncidentType
{
	[JsonPropertyName("name")]
	public required string Name { get; set; }
}
