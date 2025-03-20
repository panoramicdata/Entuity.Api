using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.ZonesData.Get;

/// <summary>
/// Representss a Zone
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13830161498909-Zones-RESTful-API#get'/></para>
/// </summary>
public class Zone : Entity<string>, IGetItem
{
	/// <summary>
	/// Entuity server ID on which resource resides
	/// </summary>
	[JsonPropertyName("serverId")]
	public Guid ServerId { get; set; }

	/// <summary>
	/// Zone name
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; } = string.Empty;
}