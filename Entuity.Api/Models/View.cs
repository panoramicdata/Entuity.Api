using System.Text.Json.Serialization;

namespace Entuity.Api.Models;

public class View : Entity<string>
{
	[JsonPropertyName("serverId")]
	public required string ServerId { get; set; }

	[JsonPropertyName("displayName")]
	public required string DisplayName { get; set; }

	[JsonPropertyName("path")]
	public required string Path { get; set; }
}

