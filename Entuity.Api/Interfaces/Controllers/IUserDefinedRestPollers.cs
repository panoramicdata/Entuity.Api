using Entuity.Api.Collections;
using Entuity.Api.Models.UserDefinedRestPollersData.Get;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface IUserDefinedRestPollers
{
	/// <summary>
	/// Get all user defined REST pollers
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/ud/pollers")]
	public Task<Response<RestPoller>> GetAllAsync(CancellationToken cancellationToken);
}
