using Entuity.Api.Models;
using Entuity.Api.QueryParameters;
using Refit;

namespace Entuity.Api.Interfaces;

public interface IIncidents
{
	/// <summary>
	/// Returns a collection of all Incidents
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/incidents")]
	Task<IncidentResponse> GetAllAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Returns a collection of all Incidents, filtered by filter options
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/incidents")]
	Task<IncidentResponse> GetAllAsync([Query] IncidentsFilter filter, CancellationToken cancellationToken);

	/// <summary>
	/// Returns a collection of all types of Incidents
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/incidentTypes")]
	Task<IncidentTypeResponse> GetAllTypesAsync(CancellationToken cancellationToken);
}