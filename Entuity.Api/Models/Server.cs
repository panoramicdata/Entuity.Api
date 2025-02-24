using System.Text.Json.Serialization;

namespace Entuity.Api.Models;

/// <summary>
/// Server
/// </summary>
public class Server : Entity
{
	[JsonPropertyName("serverId")]
	public Guid ServerId { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; } = string.Empty;
}