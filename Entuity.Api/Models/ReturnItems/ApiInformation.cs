using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.ReturnItems;

/// <summary>
/// Information about the API.
/// </summary>
public class ApiInformation : Entity<string>, IReturnItem
{
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

