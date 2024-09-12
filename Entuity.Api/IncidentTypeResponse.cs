using Entuity.Api.Models;
using System.Text.Json.Serialization;

namespace Entuity.Api;

public class IncidentTypeResponse
{
	[JsonPropertyName("items")]
	public required ICollection<IncidentType> Items { get; set; }

	[JsonPropertyName("count")]
	public int Count { get; set; }
}