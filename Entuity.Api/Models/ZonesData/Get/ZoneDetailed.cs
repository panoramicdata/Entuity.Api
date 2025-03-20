using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.ZonesData.Get;

/// <summary>
/// Holds Detailed information about a Zone
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13830223150621-Zone-Details-RESTful-API#get'/></para>
/// </summary>
public class ZoneDetailed : Entity<int>, IGetItem
{
	/// <summary>
	/// Zone name
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Zone flags
	/// </summary>
	[JsonPropertyName("flags")]
	public int Flags { get; set; }

	/// <summary>
	/// Description of the zone
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// IPv4 interface for the zone
	/// </summary>
	[JsonPropertyName("v4Interface")]
	public string V4Interface { get; set; } = string.Empty;

	/// <summary>
	/// IPv6 interface for the zone
	/// </summary>
	[JsonPropertyName("v6Interface")]
	public string V6Interface { get; set; } = string.Empty;

	/// <summary>
	/// Domain suffix for the zone
	/// </summary>
	[JsonPropertyName("domainSuffix")]
	public string DomainSuffix { get; set; } = string.Empty;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("proxy")]
	public string Proxy { get; set; } = string.Empty;

	/// <summary>
	/// Currently unused <a href='https://support.entuity.com/hc/en-us/articles/13830223150621-Zone-Details-RESTful-API#get'>as seen here</a>
	/// </summary>
	[JsonPropertyName("devicePrefix")]
	public string DevicePrefix { get; set; } = string.Empty;

	/// <summary>
	/// Host file
	/// </summary>
	[JsonPropertyName("hostFile")]
	public string HostFile { get; set; } = string.Empty;

	/// <summary>
	/// List of DNS server IP Addresses
	/// </summary>
	[JsonPropertyName("dnsServers")]
	public IEnumerable<string> DnsServers { get; set; } = [];
}
