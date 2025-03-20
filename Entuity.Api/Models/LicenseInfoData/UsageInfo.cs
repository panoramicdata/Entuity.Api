namespace Entuity.Api.Models.LicenseInfoData;

public class Usageinfo
{
	public string Name { get; set; } = string.Empty;

	public string DisplayName { get; set; } = string.Empty;

	public int Total { get; set; }

	public int Used { get; set; }

	public bool Unlimited { get; set; }

	public int Available { get; set; }
}
