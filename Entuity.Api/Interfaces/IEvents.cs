using Entuity.Api.Models;
using Refit;

namespace Entuity.Api.Interfaces;

public interface IEvents
{
	/// <summary>
	/// Returns all events
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/events")]
	Task<EventsResponse> GetAllAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Returns events that have been opened after a given time
	/// </summary>
	/// <param name="startEpoch">The start epoch time</param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/events?openedFrom={startEpoch}")]
	Task<EventsResponse> GetEventsOpenedFrom(int startEpoch, CancellationToken cancellationToken);

	/// <summary>
	/// Returns events that have been opened until a given time
	/// </summary>
	/// <param name="endEpoch">The end epoch time</param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/events?openedTo={endEpoch}")]
	Task<EventsResponse> GetEventsOpenedTo(int endEpoch, CancellationToken cancellationToken);

	/// <summary>
	/// Returns events that have been closed after a given time
	/// </summary>
	/// <param name="startEpoch">The start epoch time</param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/events?closedFrom={startEpoch}")]
	Task<EventsResponse> GetEventsClosedFrom(int startEpoch, CancellationToken cancellationToken);

	/// <summary>
	/// Returns events that have been closed before a given time
	/// </summary>
	/// <param name="endEpoch">The end epoch time</param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/events?closedTo={endEpoch}")]
	Task<EventsResponse> GetEventsClosedTo(int endEpoch, CancellationToken cancellationToken);

	/// <summary>
	/// Returns events with an Information Severity rating (value of 2)
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/events?mask=1")]
	Task<EventsResponse> GetInfoEvents(CancellationToken cancellationToken);

	/// <summary>
	/// Returns events with a Minor Severity rating (value of 4)
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/events?mask=2")]
	Task<EventsResponse> GetMinorEvents(CancellationToken cancellationToken);

	/// <summary>
	/// Returns events with a Major Severity rating (value of 6)
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/events?mask=4")]
	Task<EventsResponse> GetMajorEvents(CancellationToken cancellationToken);

	/// <summary>
	/// Returns events with a Severe Severity rating (value of 8)
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/events?mask=8")]
	Task<EventsResponse> GetSevereEvents(CancellationToken cancellationToken);

	/// <summary>
	/// Returns events with a Critical Severity rating (value of 10)
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/events?mask=16")]
	Task<EventsResponse> GetCriticalEvents(CancellationToken cancellationToken);

	/// <summary>
	/// Returns events with a status of Open
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/events?states=open")]
	Task<EventsResponse> GetOpenEvents(CancellationToken cancellationToken);

	/// <summary>
	/// Returns events with a status of Closed
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/events?states=closed")]
	Task<EventsResponse> GetClosedEvents(CancellationToken cancellationToken);

	/// <summary>
	/// Returns events with a status of Finalized
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/events?states=finalized")]
	Task<EventsResponse> GetFinalizedEvents(CancellationToken cancellationToken);

	/// <summary>
	/// Returns all Types of Events
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/eventTypes")]
	Task<EventsTypeResponse> GetAllTypesAsync(CancellationToken cancellationToken);

	//Getting events by ID is not supported
}