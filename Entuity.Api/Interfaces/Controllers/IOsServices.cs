using Entuity.Api.Models.OsServiceData.Get;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface IOsServices
{
	/// <summary>
	/// Get all Os Service rules
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/osService")]
	Task<OsServiceResponse> GetAllAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Get a specific Os Service rule by ID
	/// </summary>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/osService/{id}")]
	Task<OsService> GetAsync(int id, CancellationToken cancellationToken);
}
