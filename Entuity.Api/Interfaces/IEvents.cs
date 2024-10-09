using Entuity.Api.Models;
using Entuity.Api.Query_Parameters;
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

	[Get("/api/events")]
	Task<EventsResponse> GetAllAsync([Query] EventsFilter parameters, CancellationToken cancellationToken);

	/// <summary>
	/// Returns all Types of Events
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/eventTypes")]
	Task<EventsTypeResponse> GetAllTypesAsync(CancellationToken cancellationToken);

	//Getting events by ID is not supported
}