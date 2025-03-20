using Entuity.Api.Collections;
using Entuity.Api.Models;
using Entuity.Api.Models.ZonesData.Get;
using Entuity.Api.Models.ZonesData.Post;
using Entuity.Api.Models.ZonesData.Update;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

/// <summary>
/// Zones
/// see https://support.entuity.com/hc/en-us/articles/13830161498909-Zones-RESTful-API
/// see https://support.entuity.com/hc/en-us/articles/13830223150621-Zone-Details-RESTful-API
/// </summary>
public interface IZones
{
	/// <summary>
	/// Get all Zones
	/// </summary>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/zones")]
	Task<Response<Zone>> GetAllAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Get Zone Details
	/// </summary>
	/// <param name="id">Zone ID</param>
	/// <param name="cancellationToken"></param>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns></returns>
	[Get("/api/zones/{id}")]
	Task<ZoneDetailed> GetAsync(int id,
		CancellationToken cancellationToken);

	/// <summary>
	/// Create new Zone and get a response of all Zones
	/// </summary>
	/// <param name="zone"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Post("/api/zones")]
	Task<IApiResponse<Response<Zone>>> CreateAsync([Body] ZoneCreate zone,
		CancellationToken cancellationToken);

	/// <summary>
	/// Delete a zone by ID
	/// </summary>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Delete("/api/zones/{id}")]
	Task<IApiResponse<Message>> DeleteAsync(int id,
		CancellationToken cancellationToken);

	/// <summary>
	/// Update a zone by ID
	/// </summary>
	/// <param name="id"></param>
	/// <param name="zone"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Put("/api/zones/{id}")]
	Task<IApiResponse<ZoneDetailed>> UpdateAsync(int id,
		[Body] ZoneUpdate zone,
		CancellationToken cancellationToken);
}
