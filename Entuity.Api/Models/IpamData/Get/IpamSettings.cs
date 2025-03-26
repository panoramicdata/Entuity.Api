namespace Entuity.Api.Models.IpamData.Get;

public class IpamSettings
{
	public int DhcpScanPeriodHours { get; set; }

	public int UsageHigh { get; set; }

	public bool UsageEvents { get; set; }

	public int MaxScannableLength { get; set; }

	public int UsageMedium { get; set; }

	public int HistoryExpiry { get; set; }

	public int ActiveTimeframeHours { get; set; }

	public int ScanPeriodHours { get; set; }

	public bool DhcpConflictEvents { get; set; }
}