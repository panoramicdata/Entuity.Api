using System.Text.Json.Serialization;

namespace Entuity.Api.Models;

public class Server
{
	[JsonPropertyName("serverId")]
	public Guid ServerId { get; set; }

	[JsonPropertyName("id")]
	public Guid Id { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; } = string.Empty;
}