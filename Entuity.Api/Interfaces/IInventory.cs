using Entuity.Api.Models;
using Refit;

namespace Entuity.Api.Interfaces;

public interface IInventory
{
	[Get("/api/inventory")]
	Task<Response<InventoryItem>> GetAllAsync(CancellationToken cancellationToken);

	[Get("/api/inventory/{id}")]
	Task<Response<InventoryItem>> GetAsync(string id, CancellationToken cancellationToken);
}
