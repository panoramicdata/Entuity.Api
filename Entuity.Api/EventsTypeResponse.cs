using Entuity.Api.Models;
using System.Text.Json.Serialization;

namespace Entuity.Api;

public class EventsTypeResponse
{
	[JsonPropertyName("items")]
	public required ICollection<EventsType> Items { get; set; }

	[JsonPropertyName("count")]
	public required int Count { get; set; }
}