using Entuity.Api.Models;
using Entuity.Api.Models.Collections;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface IUserDefinedRestPollers
{
	[Get("/api/ud/pollers")]
	public Task<Response<RestPoller>> GetAllAsync(CancellationToken cancellationToken);
}
