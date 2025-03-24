using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.LicenseInfoData.Get;

/// <summary>
/// Holds information about the license metrics
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13839734037021-License-Usage-RESTful-API#get'/></para>
/// </summary>
public class LicenseInfo : IGetItem
{
	public Guid ServerId { get; set; }

	public string ExpiryDate { get; set; } = string.Empty;

	public string LicenseType { get; set; } = string.Empty;

	public string Platform { get; set; } = string.Empty;

	public IEnumerable<License> Licenses { get; set; } = [];
}
