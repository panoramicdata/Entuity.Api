using Entuity.Api.Models;
using Refit;

namespace Entuity.Api.Interfaces;

public interface IIncidents
{
	/// <summary>
	/// Returns all Incidents
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/incidents")]
	Task<IncidentResponse> GetAllAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Returns Incidents of a given Severity
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item>Information - Severity of 1</item>
	/// <item>Minor - Severity of 2</item>
	/// <item>Major - Severity of 4</item>
	/// <item>Severe - Severity of 8</item>
	/// <item>Critical - Severity of 16</item>
	/// </list>
	/// </remarks>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/incidents?mask={severity}")]
	Task<IncidentResponse> GetBySeverity(int severity, CancellationToken cancellationToken);
	/// <summary>
	/// Returns all types of Incidents
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/incidentTypes")]
	Task<IncidentTypeResponse> GetAllTypesAsync(CancellationToken cancellationToken);
}