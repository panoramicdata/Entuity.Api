using System.Text.Json.Serialization;

namespace Entuity.Api.Models;

public class Zone : Entity<string>
{
	[JsonPropertyName("serverId")]
	public Guid ServerId { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; } = string.Empty;
}