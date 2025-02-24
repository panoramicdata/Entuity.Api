using System.Text.Json.Serialization;

namespace Entuity.Api.Models;

/// <summary>
/// Information about the API.
/// </summary>
public class ApiInformation
{
	[JsonPropertyName("id")]
	public required string Id { get; set; }

	[JsonPropertyName("version")]
	public required string Version { get; set; }

	[JsonPropertyName("versionDisplay")]
	public required string VersionDisplay { get; set; }

	[JsonPropertyName("product")]
	public required string Product { get; set; }

	[JsonPropertyName("hostAddress")]
	public required string HostAddress { get; set; }

	[JsonPropertyName("webPort")]
	public int WebPort { get; set; }

	[JsonPropertyName("sslAccess")]
	public bool SslAccess { get; set; }
}

