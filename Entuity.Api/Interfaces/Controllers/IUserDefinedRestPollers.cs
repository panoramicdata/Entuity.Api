using Entuity.Api.Models.Collections;
using Entuity.Api.Models.ReturnItems;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface IUserDefinedRestPollers
{
	[Get("/api/ud/pollers")]
	public Task<Response<RestPoller>> GetAllAsync(CancellationToken cancellationToken);
}
