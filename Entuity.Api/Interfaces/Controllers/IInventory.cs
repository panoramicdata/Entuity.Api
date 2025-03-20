using Entuity.Api.Collections;
using Entuity.Api.Models.GetItems;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;
/// <summary>
/// Inventory
/// see https://support.entuity.com/hc/en-us/articles/13819757448349-Asset-Management-Device-Inventory-RESTful-API
/// </summary>
public interface IInventory
{
	/// <summary>
	/// Get all Inventory Items
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns></returns>
	[Get("/api/inventory")]
	Task<Response<InventoryItemSimple>> GetAllAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Get Inventory Item
	/// </summary>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns></returns>
	[Get("/api/inventory/{id}")]
	Task<InventoryItemDetailed> GetAsync(string id, CancellationToken cancellationToken);
}
