using Entuity.Api.Models;
using Entuity.Api.Models.OsServiceData.Get;
using Entuity.Api.Models.OsServiceData.Post;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface IOsServices
{
	/// <summary>
	/// Get all OS Service rules
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/osService")]
	Task<OsServiceResponse> GetAllAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Create new OS Service rules
	/// </summary>
	/// <param name="osServiceCollectionPost"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Post("/api/osService")]
	Task<OsServiceResponse> CreateAsync([Body] OsServiceCollectionCreate osServiceCollectionPost, CancellationToken cancellationToken);

	/// <summary>
	/// Get a specific OS Service rule by ID
	/// </summary>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/osService/{id}")]
	Task<OsService> GetAsync(int id, CancellationToken cancellationToken);

	/// <summary>
	/// Delete an OS Service rule by ID
	/// </summary>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Delete("/api/osService/{id}")]
	Task<Message> DeleteAsync(int id, CancellationToken cancellationToken);
}
