using System.Text.Json.Serialization;

namespace Entuity.Api.Models;

public class EventsType : Entity<int>
{
	[JsonPropertyName("name")]
	public required string Name { get; set; }

	[JsonPropertyName("severity")]
	public required int Severity { get; set; }
}
