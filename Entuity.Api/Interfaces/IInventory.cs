using Entuity.Api.Models;
using Refit;

namespace Entuity.Api.Interfaces;
/// <summary>
/// Inventory
/// see https://support.entuity.com/hc/en-us/articles/13819757448349-Asset-Management-Device-Inventory-RESTful-API
/// </summary>
public interface IInventory
{
	/// <summary>
	/// 
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns></returns>
	[Get("/api/inventory")]
	Task<Response<InventoryItem>> GetAllAsync(CancellationToken cancellationToken);

	/// <summary>
	/// 
	/// </summary>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns></returns>
	[Get("/api/inventory/{id}")]
	Task<Response<InventoryItem>> GetAsync(string id, CancellationToken cancellationToken);
}
