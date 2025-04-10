using Entuity.Api.Collections;
using Entuity.Api.Models.MerakiCloudControllersData.Get;
using Entuity.Api.QueryParameters;
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

	/// <summary>
	/// Get all Meraki Cloud Controllers with filter
	/// </summary>
	/// <param name="filter"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/MerakiCloudControllers")]
	Task<Response<MerakiCloudController>> GetAllAsync([Query] MerakiCloudControllersFilter filter, CancellationToken cancellationToken);
}
