using System.Text.Json.Serialization;

namespace Entuity.Api.Models;

public class IncidentTypeResponse
{
	[JsonPropertyName("items")]
	public required ICollection<IncidentType> Items { get; set; }

	[JsonPropertyName("count")]
	public int Count { get; set; }
}