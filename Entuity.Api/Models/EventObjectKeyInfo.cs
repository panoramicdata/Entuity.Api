using System.Text.Json.Serialization;

namespace Entuity.Api.Models;

public class EventObjectKeyInfo
{
	[JsonPropertyName("swId")]
	public required int SwId { get; set; }

	[JsonPropertyName("compId")]
	public required EventCompId CompId { get; set; }
}
