using System.Text.Json.Serialization;

namespace Entuity.Api.Models.IpamData.Update;

/// <summary>
/// Holds settings that can be updated for IPAM
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13839876995741-IPAM-Settings-and-Scanning-RESTful-API#put'/></para>
/// </summary>
public class IpamSettingsUpdate
{
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? HistoryExpiry { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? UsageEvents { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? UsageMedium { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? ScanPeriodHours { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? UsageHigh { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? MaxScannableLength { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? DhcpConflictEvents { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? DhcpScanPeriodHours { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? ActiveTimeframeHours { get; set; }
}

