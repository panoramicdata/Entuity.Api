using Entuity.Api.Models;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface IAutoDiscovery
{
	[Get("/api/autodiscovery")]
	Task<AutoDiscoveryResponse> GetAllAsync(CancellationToken cancellationToken);

}
