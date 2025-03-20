namespace Entuity.Api.Models.LicenseInfoData;

public class License
{
	public string Name { get; set; } = string.Empty;

	public string DisplayName { get; set; } = string.Empty;

	public bool Enabled { get; set; }

	public bool Module { get; set; }

	public bool FromLicenseServer { get; set; }

	public required Usageinfo UsageInfo { get; set; }

	public required Expiryinfo ExpiryInfo { get; set; }

	public string Source { get; set; } = string.Empty;
}
