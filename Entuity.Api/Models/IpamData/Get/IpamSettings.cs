namespace Entuity.Api.Models.IpamData.Get;

/// <summary>
/// Holds information about IPAM settings
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13839876995741-IPAM-Settings-and-Scanning-RESTful-API#get'/></para>
/// </summary>
public class IpamSettings
{
	/// <summary>
	/// Number of hours between scheduled DHCP server scans. Must be an integer between 2 and 48, by default 4
	/// </summary>
	public int DhcpScanPeriodHours { get; set; }

	/// <summary>
	/// % threshold above which the network usage bar in the Networks table will turn yellow. Must be between 1 and 100
	/// </summary>
	public int UsageHigh { get; set; }

	/// <summary>
	/// If usage % events are enabled, either 'true' or 'false'
	/// </summary>
	public bool UsageEvents { get; set; }

	/// <summary>
	/// maximum number of IP addresses in a range that a single network can cover, if scanning is enabled, one of the following:
	/// <list type="bullet">
	/// <item>0: 64 (/26)</item>
	/// <item>1: 128 (/25)</item>
	/// <item>2: 256 (/24)</item>
	/// <item>3: 512 (/23)</item>
	/// <item>4: 1024 (/22)</item>
	/// <item>5: 2048 (/21)</item>
	/// <item>6: 4096 (/20)</item>
	/// <item>7: 8192 (/19</item>
	/// <item>8: 16384 (/18)</item>
	/// <item>9: 32768 (/17)</item>
	/// <item>10: 65536 (/16)</item>
	/// </list>
	/// </summary>
	public int MaxScannableLength { get; set; }

	/// <summary>
	/// % threshold above which the network usage bar in the Networks table will turn yellow. Must be between 1 and 100, by default 50
	/// </summary>
	public int UsageMedium { get; set; }

	/// <summary>
	/// Number of days before history entries are removed from the IP History table. Must be an integer between 1 and 14, by default 7
	/// </summary>
	public int HistoryExpiry { get; set; }

	/// <summary>
	/// Timeframe (in hours) in which a successful scan of an IP address should fall to be considered active, by default 12. I.e., if an IP address was last successfully scanned within the last 12 hours, then the IP address is considered active. Must be an integer between 2 and 72, and must be greater than both scanPeriodHours and dchpScanPeriodHours
	/// </summary>
	public int ActiveTimeframeHours { get; set; }

	/// <summary>
	/// Number of hours betwen scheduled Ping, Reverse DNS, and ARP scans. Must be an integer between 1 and 24, by default 2
	/// </summary>
	public int ScanPeriodHours { get; set; }

	/// <summary>
	/// If DHCP Conflict Events are enabled, either 'true' or 'false'
	/// </summary>
	public bool DhcpConflictEvents { get; set; }
}