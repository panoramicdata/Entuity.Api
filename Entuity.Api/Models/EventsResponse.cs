using System.Text.Json.Serialization;

namespace Entuity.Api.Models;

public class EventsResponse
{
	[JsonPropertyName("events")]
	public required ICollection<Event> Events { get; set; }

	[JsonPropertyName("updateId")]
	public int UpdateId { get; set; }

	[JsonPropertyName("count")]
	public int Count { get; set; }
}