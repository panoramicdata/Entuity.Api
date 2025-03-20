using System.Text.Json.Serialization;

namespace Entuity.Api.Models.ZonesData.Post;

/// <summary>
/// Holds required and optional information to create a Zone
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13830161498909-Zones-RESTful-API#post'/></para>
/// </summary>
public class ZoneCreate
{
	/// <summary>
	/// Name of the Zone
	/// </summary>
	public required string Name { get; set; }

	/// <summary>
	/// IPv4 interface for the zone
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? V4Interface { get; set; }

	/// <summary>
	/// IPv6 interface for the zone
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? V6Interface { get; set; }

	/// <summary>
	/// Domain suffix for the zone
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? DomainSuffix { get; set; }

	/// <summary>
	/// Currently unused <a href='https://support.entuity.com/hc/en-us/articles/13830161498909-Zones-RESTful-API#post'>as seen here</a>
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Proxy { get; set; }

	/// <summary>
	/// Specified device prefix that is included with each device name found udner this zone, maximum of 5 characters
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? DevicePrefix { get; set; }

	/// <summary>
	/// Host File
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? HostFile { get; set; }

	/// <summary>
	/// List of DNS server IP Addresses
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public IEnumerable<string>? DnsServers { get; set; }

}
