using Entuity.Api.Models;
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
	/// Returns a collection of Incidents with a state of "Open"
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/incidents?states=open")]
	Task<IncidentResponse> GetOpen(CancellationToken cancellationToken);

	/// <summary>
	/// Returns a collection of Incidents with a state of "Closed"
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/incidents?states=closed")]
	Task<IncidentResponse> GetClosed(CancellationToken cancellationToken);

	/// <summary>
	/// Returns a collection of Incidents with a state of "Expired"
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/incidents?states=open")]
	Task<IncidentResponse> GetExpired(CancellationToken cancellationToken);

	/// <summary>
	/// Returns a collection of Incidents with a state of "Open" or "Closed"
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/incidents?states=open&stastes=closed")]
	Task<IncidentResponse> GetNonExpired(CancellationToken cancellationToken);

	/// <summary>
	/// Get Incidents From a time
	/// </summary>
	/// <param name="startEpoch">The epoch time for the lower bound</param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/incidents?openedFrom={startEpoch}")]
	Task<IncidentResponse> GetOpenedFrom(int startEpoch, CancellationToken cancellationToken);

	/// <summary>
	/// Get Incidents up to a time
	/// </summary>
	/// <param name="endEpoch">The epoch time for the upper bound</param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/incidents?openedTo={endEpoch}")]
	Task<IncidentResponse> GetOpenedTo(int endEpoch, CancellationToken cancellationToken);

	/// <summary>
	/// Get Incidents that were closed after a given time
	/// </summary>
	/// <param name="startEpoch">The epoch time for the lower bound</param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/incidents?closedFrom={startEpoch}")]
	Task<IncidentResponse> GetClosedFrom(int startEpoch, CancellationToken cancellationToken);

	/// <summary>
	/// Get Incidents that were closed before a given time
	/// </summary>
	/// <param name="endEpoch">The epoch time for the upper bound</param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/incidents?closedTo={endEpoch}")]
	Task<IncidentResponse> GetClosedTo(int endEpoch, CancellationToken cancellationToken);

	/// <summary>
	/// Gets Incidents that sit within a time range
	/// </summary>
	/// <param name="startEpoch">The Epoch time of the lower bound</param>
	/// <param name="endEpoch">The Epoch time of the upper bound</param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/incidents?openedFrom={startEpoch}&closedTo={endEpoch}")]
	Task<IncidentResponse> GetOpenedBetween(int startEpoch, int endEpoch, CancellationToken cancellationToken);


	/// <summary>
	/// Returns a collection of all types of Incidents
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/incidentTypes")]
	Task<IncidentTypeResponse> GetAllTypesAsync(CancellationToken cancellationToken);
}