using Entuity.Api.Models;
using Refit;

namespace Entuity.Api.Interfaces;

public interface IEvents
{
	[Get("/api/events")]
	Task<EventsResponse> GetAllAsync(CancellationToken cancellationToken);

	[Get("/api/events/{id}")]
	Task<Response<InventoryItem>> GetAsync(int id, CancellationToken cancellationToken);
}