using Entuity.Api.Models;
using Entuity.Api.Query_Parameters;
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
	/// Gets Incidents with an Information Severity Rating (value of 2)
	/// </summary>
	/// <param name="severity"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/incidents?mask=1")]
	Task<IncidentResponse> GetInfoIncidents(CancellationToken cancellationToken);


	/// <summary>
	/// Gets Incidents with a Minor Severity Rating (value of 4)
	/// </summary>
	/// <param name="severity"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/incidents?mask=2")]
	Task<IncidentResponse> GetMinorIncidents(CancellationToken cancellationToken);


	/// <summary>
	/// Gets Incidents with a Major Severity Rating (value of 6)
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/incidents?mask=4")]
	Task<IncidentResponse> GetMajorIncidents(CancellationToken cancellationToken);

	/// <summary>
	/// Gets Incidents with a Severe Severity Rating (value of 8)
	/// </summary>
	/// <param name="severity"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/incidents?mask=8")]
	Task<IncidentResponse> GetSevereIncidents(CancellationToken cancellationToken);

	/// <summary>
	/// Gets Incidents with a Critical Severity Rating (value of 10)
	/// </summary>
	/// <param name="severity"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/incidents?mask=16")]
	Task<IncidentResponse> GetCriticalIncidents(CancellationToken cancellationToken);

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