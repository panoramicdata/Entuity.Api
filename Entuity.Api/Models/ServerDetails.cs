using System.Text.Json.Serialization;

namespace Entuity.Api.Models;

public class ServerDetails
{
	[JsonPropertyName("serverId")]
	public Guid ServerId { get; set; }

	[JsonPropertyName("role")]
	public string Role { get; set; } = string.Empty;

	[JsonPropertyName("local")]
	public bool Local { get; set; }

	[JsonPropertyName("webPort")]
	public int WebPort { get; set; }

	[JsonPropertyName("licensed")]
	public bool Licensed { get; set; }

	[JsonPropertyName("ssl")]
	public bool Ssl { get; set; }

	[JsonPropertyName("included")]
	public bool Included { get; set; }

	[JsonPropertyName("centralServer")]
	public bool CentralServer { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; } = string.Empty;
}