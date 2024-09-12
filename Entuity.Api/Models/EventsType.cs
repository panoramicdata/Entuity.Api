using System.Text.Json.Serialization;

namespace Entuity.Api.Models;

public class EventsType : IntIdentifiedEntity
{
	[JsonPropertyName("name")]
	public required string Name { get; set; }

	[JsonPropertyName("severity")]
	public required int Severity { get; set; }
}
