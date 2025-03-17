using Entuity.Api.Models.GetItems;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface ILicenseInfo
{
	[Get("/api/licenseinfo")]
	Task<LicenseInfo> GetLicenseInfoAsync(CancellationToken cancellationToken);
}
