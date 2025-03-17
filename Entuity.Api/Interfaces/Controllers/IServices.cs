using Entuity.Api.Models.Collections;
using Entuity.Api.Models.GetItems;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface IServices
{
	[Get("/api/service")]
	public Task<Response<Service>> GetAllAsync(CancellationToken cancellationToken);

	[Get("/api/service/{serviceId}")]
	public Task<ServiceDetailed> GetAsync(int serviceId, CancellationToken cancellationToken);
}
