using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.IpamData.Get;


public class Network : Entity<int>, IGetItem
{
	/// <summary>
	/// User-specified name of the network.
	/// </summary>
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// IP range of the network.
	/// </summary>
	public string IpRange { get; set; } = string.Empty;

	/// <summary>
	/// Role of the network, one of the following:
	/// <list type="bullet">
	/// <item>Supernet</item>
	/// <item>Subnet</item>
	/// <item>Range</item>
	/// </list>
	/// </summary>
	public int Role { get; set; }

	/// <summary>
	/// Zone ID if applicable. Note:
	/// <list type="bullet">
	/// <item>A network can only belong to one zone.</item>
	/// <item>Multiple networks with the same IP range can exist within different zones. Consequently, the same IP addresses scanned with different zones will then result as different IP addresses, and subsequently can only be acessed from the corresponding zone/network.</item>
	/// <item>ARP scans will inherit the zone from its routers.</item>
	/// </list>
	/// </summary>
	public int? ZoneID { get; set; }

	/// <summary>
	/// User-specified description of the network.
	/// </summary>
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Name of the DHCP server assigned to this network, if applicable.
	/// </summary>
	public int DhcpServer { get; set; }

	/// <summary>
	/// Which scans are being used for this network, if any.
	/// </summary>
	public int Scans { get; set; }

	/// <summary>
	/// ID of the parent network, if applicable
	/// </summary>
	public int ParentID { get; set; }

	/// <summary>
	/// % threshold value in which the usage will be yellow, by default a global value.
	/// </summary>
	public int UsageMedium { get; set; }

	/// <summary>
	/// % threshold value in which the usage will be red, by default a global value.
	/// </summary>
	public int UsageHigh { get; set; }

	/// <summary>
	/// If the network is to be skipped for scanning ('don't scan network/address broadcast' in the UI), either 'true' or 'false'.
	/// </summary>
	public bool SkipNetwork { get; set; }

	/// <summary>
	/// Number of scanned IPs that are active.
	/// </summary>
	public int ActiveIps { get; set; }

	/// <summary>
	/// Total number of IPs covered by the network range.
	/// </summary>
	public int TotalIps { get; set; }

	/// <summary>
	/// Names of other scopes that conflict with this one.
	/// </summary>
	public object? Conflict { get; set; }

	/// <summary>
	/// Timestamp of the conflict.
	/// </summary>
	public int ConflictTimestamp { get; set; }

	/// <summary>
	/// Number of children of the network, if applicable.
	/// </summary>
	public IEnumerable<int> Children { get; set; } = [];

	/// <summary>
	/// full path of IP range hierarchy to this network, useful for when networks have the same name but different parents, e.g. in the case of two networks both called 'test':
	/// <para>parent 1/test</para>
	/// <para>parent 2/test</para>
	/// </summary>
	public string FullPath { get; set; } = string.Empty;

	/// <summary>
	/// If the activeIps % exceeds the 'usageHigh' threshold.
	/// </summary>
	public bool ExceedsUsage { get; set; }

	public object? IpamRange { get; set; }
}

