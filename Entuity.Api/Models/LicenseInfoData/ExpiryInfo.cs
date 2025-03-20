namespace Entuity.Api.Models.LicenseInfoData;

public class Expiryinfo
{
	public bool Licensed { get; set; }

	public bool Expired { get; set; }

	public long? Expiry { get; set; }

	public string AsString { get; set; } = string.Empty;
}
