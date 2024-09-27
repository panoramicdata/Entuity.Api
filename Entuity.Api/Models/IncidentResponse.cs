using System.Text.Json.Serialization;

namespace Entuity.Api.Models;

public class IncidentResponse
{
	[JsonPropertyName("incidents")]
	public required ICollection<Incident> Incidents { get; set; }

	[JsonPropertyName("updateId")]
	public int UpdateId { get; set; }

	[JsonPropertyName("count")]
	public int Count { get; set; }
}