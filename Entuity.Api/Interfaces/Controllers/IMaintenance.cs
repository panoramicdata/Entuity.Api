using Entuity.Api.Collections;
using Entuity.Api.Models;
using Entuity.Api.Models.MaintenanceData.Get;
using Entuity.Api.Models.MaintenanceData.Post;
using Entuity.Api.Models.MaintenanceData.Update;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;
public interface IMaintenance
{
	/// <summary>
	/// Get all maintenance schedules
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/maintenance")]
	Task<Response<Maintenance>> GetAllAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Create a new maintenance schedule
	/// </summary>
	/// <param name="maintenanceCreate"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Post("/api/maintenance")]
	Task<MaintenanceDetailed> CreateAsync([Body] MaintenanceCreate maintenanceCreate, CancellationToken cancellationToken);

	/// <summary>
	/// Get a maintenance schedule by ID
	/// </summary>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/maintenance/{id}")]
	Task<MaintenanceDetailed> GetAsync(int id, CancellationToken cancellationToken);

	/// <summary>
	/// Update a maintenance schedule by ID
	/// </summary>
	/// <param name="id"></param>
	/// <param name="maintenanceUpdate"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Put("/api/maintenance/{id}")]
	Task<MaintenanceDetailed> UpdateAsync(int id, [Body] MaintenanceUpdate maintenanceUpdate, CancellationToken cancellationToken);

	/// <summary>
	/// Delete a maintenance schedule by ID
	/// </summary>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Delete("/api/maintenance/{id}")]
	Task<Message> DeleteAsync(int id, CancellationToken cancellationToken);

}
