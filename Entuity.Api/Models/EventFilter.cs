using System.Text.Json.Serialization;

namespace Entuity.Api.Models;

public class EventFilter : Entity<string>
{
	[JsonPropertyName("serverId")]
	public required string ServerId { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; } = string.Empty;
}

