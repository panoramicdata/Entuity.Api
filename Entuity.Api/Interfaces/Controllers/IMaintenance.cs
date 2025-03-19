using Entuity.Api.Models;
using Entuity.Api.Models.Collections;
using Entuity.Api.Models.GetItems;
using Entuity.Api.Models.PostItems;
using Entuity.Api.Models.UpdateItems;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;
public interface IMaintenance
{
	[Get("/api/maintenance")]
	Task<Response<Maintenance>> GetAllAsync(CancellationToken cancellationToken);

	[Post("/api/maintenance")]
	Task<MaintenanceDetailed> CreateAsync([Body] MaintenanceCreate maintenanceCreate, CancellationToken cancellationToken);

	[Get("/api/maintenance/{id}")]
	Task<MaintenanceDetailed> GetAsync(int id, CancellationToken cancellationToken);

	[Put("/api/maintenance/{id}")]
	Task<MaintenanceDetailed> UpdateAsync(int id, [Body] MaintenanceUpdate maintenanceUpdate, CancellationToken cancellationToken);

	[Delete("/api/maintenance/{id}")]
	Task<Message> DeleteAsync(int id, CancellationToken cancellationToken);

}
