using Entuity.Api.Collections;
using Entuity.Api.Models.UserDefinedRestPollersData.Get;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface IUserDefinedRestPollers
{
	[Get("/api/ud/pollers")]
	public Task<Response<RestPoller>> GetAllAsync(CancellationToken cancellationToken);
}
