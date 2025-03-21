using Entuity.Api.Collections;
using Entuity.Api.Models;
using Entuity.Api.Models.ServicesData.Get;
using Entuity.Api.Models.ServicesData.Post;
using Entuity.Api.Models.ServicesData.Update;
using Entuity.Api.QueryParameters;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface IServices
{
	/// <summary>
	/// Get all Services
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/service")]
	public Task<Response<Service>> GetAllAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Get all Services
	/// </summary>
	/// <param name="parameters"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/service")]
	public Task<Response<Service>> GetAllAsync([Query] ServicesFilter parameters, CancellationToken cancellationToken);

	/// <summary>
	/// Create a new Service
	/// </summary>
	/// <param name="service"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Post("/api/service")]
	public Task<ServiceDetailed> CreateAsync([Body] ServiceCreate service, CancellationToken cancellationToken);

	/// <summary>
	/// Get a Service by ID
	/// </summary>
	/// <param name="serviceId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/service/{serviceId}")]
	public Task<ServiceDetailed> GetAsync(int serviceId, CancellationToken cancellationToken);

	/// <summary>
	/// Update a Service by ID
	/// </summary>
	/// <param name="serviceId"></param>
	/// <param name="service"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Put("/api/service/{serviceId}")]
	public Task<ServiceDetailed> UpdateAsync(int serviceId, [Body] ServiceUpdate service, CancellationToken cancellationToken);

	/// <summary>
	/// Delete a Service by ID
	/// </summary>
	/// <param name="serviceId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Delete("/api/service/{serviceId}")]
	public Task<Message> DeleteAsync(int serviceId, CancellationToken cancellationToken);
}
