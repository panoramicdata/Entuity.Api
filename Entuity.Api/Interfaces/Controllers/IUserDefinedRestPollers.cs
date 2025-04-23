using Entuity.Api.Collections;
using Entuity.Api.Models.UserDefinedRestPollersData;
using Entuity.Api.Models.UserDefinedRestPollersData.Get;
using Entuity.Api.Models.UserDefinedRestPollersData.Post;
using Entuity.Api.Models.UserDefinedRestPollersData.Update;
using Refit;
using System.Collections;

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

	/// <summary>
	/// Create a new user defined REST poller
	/// </summary>
	/// <param name="poller"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Post("/api/ud/pollers")]
	public Task<IApiResponse<IEnumerable>> CreateAsync([Body] RestPollerCreate poller, CancellationToken cancellationToken);

	/// <summary>
	/// Get a user defined REST poller by ID
	/// </summary>
	/// <param name="pollerId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/ud/pollers/{pollerId}")]
	public Task<RestPollerDetailed> GetAsync(int pollerId, CancellationToken cancellationToken);

	/// <summary>
	/// Update a user defined REST poller by ID
	/// </summary>
	/// <param name="pollerId"></param>
	/// <param name="poller"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Put("/api/ud/pollers/{pollerId}")]
	public Task<RestPollerDetailed> UpdateAsync(int pollerId, [Body] RestPollerUpdate poller, CancellationToken cancellationToken);

	/// <summary>
	/// Delete a user defined REST poller by ID
	/// </summary>
	/// <param name="pollerId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Delete("/api/ud/pollers/{pollerId}")]
	public Task<IApiResponse> DeleteAsync(int pollerId, CancellationToken cancellationToken);

	/// <summary>
	/// Test a user defined REST poller
	/// </summary>
	/// <param name="poller"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Post("/api/ud/test")]
	public Task<RestPollerTestResults> TestRestPollerAsync([Body] RestPollerTestInformation poller, CancellationToken cancellationToken);
}
