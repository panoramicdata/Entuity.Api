using Entuity.Api.Collections;
using Entuity.Api.Models.MerakiCloudControllersData.Get;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;
public interface IMerakiCloudControllers
{
	/// <summary>
	/// Get all Meraki Cloud Controllers
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/MerakiCloudControllers")]
	Task<Response<MerakiCloudController>> GetAllAsync(CancellationToken cancellationToken);
}
