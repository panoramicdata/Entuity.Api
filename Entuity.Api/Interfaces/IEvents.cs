using Refit;

namespace Entuity.Api.Interfaces;

public interface IEvents
{
	[Get("/api/events")]
	Task<EventsResponse> GetAllAsync(CancellationToken cancellationToken);

	//Getting events by ID is not supported
}