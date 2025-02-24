using System.Text.Json.Serialization;

namespace Entuity.Api.Models;

public class User : Entity<string>
{
	[JsonPropertyName("serverId")]
	public required string ServerId { get; set; }

	[JsonPropertyName("name")]
	public required string Name { get; set; }
}

