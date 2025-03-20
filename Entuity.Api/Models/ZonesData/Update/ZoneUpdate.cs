using System.Text.Json.Serialization;

namespace Entuity.Api.Models.ZonesData.Update;

/// <summary>
/// Holds information to update a Zone
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13830223150621-Zone-Details-RESTful-API#put'/></para>
/// </summary>
public class ZoneUpdate
{
	/// <summary>
	/// Zone Name
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Name { get; set; }

	/// <summary>
	/// Zone Flags
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? Flags { get; set; }

	/// <summary>
	/// Description of the Zone
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Description { get; set; }

	/// <summary>
	/// IPv4 interface for the Zone
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? V4Interface { get; set; }

	/// <summary>
	/// IPv6 interface for the Zone
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? V6Interface { get; set; }

	/// <summary>
	/// Domain suffix for the Zone
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? DomainSuffix { get; set; }

	/// <summary>
	/// Current unused <a href='https://support.entuity.com/hc/en-us/articles/13830223150621-Zone-Details-RESTful-API#put'>as seen here</a>
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Proxy { get; set; }

	/// <summary>
	/// Specified device prefix that is included with each device name found under this zone, maximum of 5 characters
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
