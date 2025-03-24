using Entuity.Api.Models.LicenseInfoData.Get;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface ILicenseInfo
{
	/// <summary>
	/// Get information about the license metrics
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/licenseinfo")]
	Task<LicenseInfo> GetLicenseInfoAsync(CancellationToken cancellationToken);
}
