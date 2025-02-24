using Entuity.Api.Models;
using Refit;

namespace Entuity.Api.Interfaces;

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
	Task<Response<string, Zone>> GetAllAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Get Zone Details
	/// </summary>
	/// <param name="id">Zone ID</param>
	/// <param name="cancellationToken"></param>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns></returns>
	[Get("/api/zones/{id}")]
	Task<ZoneDetails> GetAsync(int id,
		CancellationToken cancellationToken);
}
