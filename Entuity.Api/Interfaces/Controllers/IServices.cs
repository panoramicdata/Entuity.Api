using Entuity.Api.Collections;
using Entuity.Api.Models;
using Entuity.Api.Models.GetItems;
using Entuity.Api.Models.PostItems;
using Entuity.Api.Models.UpdateItems;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface IServices
{
	[Get("/api/service")]
	public Task<Response<Service>> GetAllAsync(CancellationToken cancellationToken);

	[Post("/api/service")]
	public Task<ServiceDetailed> CreateAsync([Body] ServiceCreate service, CancellationToken cancellationToken);

	[Get("/api/service/{serviceId}")]
	public Task<ServiceDetailed> GetAsync(int serviceId, CancellationToken cancellationToken);

	[Put("/api/service/{serviceId}")]
	public Task<ServiceDetailed> UpdateAsync(int serviceId, [Body] ServiceUpdate service, CancellationToken cancellationToken);

	[Delete("/api/service/{serviceId}")]
	public Task<Message> DeleteAsync(int serviceId, CancellationToken cancellationToken);
}
