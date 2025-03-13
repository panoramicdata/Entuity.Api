using Entuity.Api.Models;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface IUserDefinedRestPollers
{
	[Get("/api/ud/pollers")]
	public Task<RestPollerResponse> GetAllAsync(CancellationToken cancellationToken);
}
