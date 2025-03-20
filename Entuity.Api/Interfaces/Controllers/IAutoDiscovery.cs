using Entuity.Api.Collections;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface IAutoDiscovery
{
	/// <summary>
	/// Get all AutoDiscovery data
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/autodiscovery")]
	Task<AutoDiscoveryResponse> GetAllAsync(CancellationToken cancellationToken);

}
