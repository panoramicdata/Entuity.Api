using System.Text.Json.Serialization;

namespace Entuity.Api.Models.IpamData.Update;

/// <summary>
/// Holds the data required to update an IPAM network.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13839898833437-IPAM-Network-Details-RESTful-API#put'/></para>
/// </summary>
public class IpamNetworkUpdate
{
	/// <summary>
	/// User-specified name of the network
	/// </summary>
	public required string Name { get; set; }

	/// <summary>
	/// IP range of the network
	/// </summary>
	public required string IpRange { get; set; }

	/// <summary>
	/// User-specified description of the network
	/// </summary>
	public required string Description { get; set; }

	/// <summary>
	/// Role of the network, one of the following:
	/// <list type="bullet">
	/// <item>Supernet</item>
	/// <item>Subnet</item>
	/// <item>Range</item>
	/// </list>
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? Role { get; set; }

	/// <summary>
	/// Zone ID if applicable.Note:
	/// <list type="bullet">
	/// <item>A network can only belong to one zone</item>
	/// <item>Multiple networks with the same IP range can exist within different zones. Consequently, the same IP addresses scanned with different zones will then result as different IP addresses, and subsequently can only be acessed from the corresponding zone/network</item>
	/// <item>ARP scans will inherit the zone from its routers</item>
	/// </list>
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? ZoneID { get; set; }

	/// <summary>
	/// Name of the DHCP server assigned to this network, if applicable
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? DhcpServer { get; set; }

	/// <summary>
	/// Which scans are being used for this network, if any
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? Scans { get; set; }

	/// <summary>
	/// ID of the parent network, if applicable
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? ParentID { get; set; }

	/// <summary>
	/// % threshold value in which the usage will be yellow, by default a global value
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? UsageMedium { get; set; }

	/// <summary>
	/// % threshold value in which the usage will be red, by default a global value
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? UsageHigh { get; set; }

	/// <summary>
	/// If the network is to be skipped for scanning ('don't scan network/address broadcast' in the UI), either 'true' or 'false'
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? SkipNetwork { get; set; }
}
