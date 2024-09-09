using Refit;

namespace Entuity.Api.Interfaces;

public interface IIncidents
{
	[Get("/api/incidents")]
	Task<EventsResponse> GetAllAsync(CancellationToken cancellationToken);
}