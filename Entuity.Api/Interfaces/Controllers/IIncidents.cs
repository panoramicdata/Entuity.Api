using Entuity.Api.Collections;
using Entuity.Api.Models.GetItems;
using Entuity.Api.QueryParameters;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

/// <summary>
/// Incidents
/// see https://support.entuity.com/hc/en-us/articles/13819730123293-Incidents-RESTful-API
/// see https://support.entuity.com/hc/en-us/articles/13819715590813-Incident-Types-RESTful-API
/// see https://support.entuity.com/hc/en-us/articles/13819723797405-Incident-Details-RESTful-API
/// </summary>
public interface IIncidents
{
	/// <summary>
	/// Returns a collection of all Incidents
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns></returns>
	[Get("/api/incidents")]
	Task<IncidentResponse> GetAllAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Returns a collection of all Incidents, filtered by filter options
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns></returns>
	[Get("/api/incidents")]
	Task<IncidentResponse> GetAllAsync([Query] IncidentsFilter filter, CancellationToken cancellationToken);

	/// <summary>
	/// Returns a collection of all types of Incidents
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns></returns>
	[Get("/api/incidentTypes")]
	Task<Response<IncidentType>> GetAllTypesAsync(CancellationToken cancellationToken);
}