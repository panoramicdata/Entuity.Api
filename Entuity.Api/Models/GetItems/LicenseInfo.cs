using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.GetItems;

public class LicenseInfo : IGetItem
{
	public Guid ServerId { get; set; }

	public string ExpiryDate { get; set; } = string.Empty;

	public string LicenseType { get; set; } = string.Empty;

	public string Platform { get; set; } = string.Empty;

	public IEnumerable<License> Licenses { get; set; } = [];
}
