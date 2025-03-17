using Entuity.Api.Models.Collections;
using Entuity.Api.Models.GetItems;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;
public interface IMaintenance
{
	[Get("/api/maintenance")]
	Task<Response<Maintenance>> GetAllAsync(CancellationToken cancellationToken);
}
