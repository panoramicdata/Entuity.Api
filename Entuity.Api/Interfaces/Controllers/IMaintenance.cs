using Entuity.Api.Models.Collections;
using Entuity.Api.Models.ReturnItems;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;
public interface IMaintenance
{
	[Get("/api/maintenance")]
	Task<Response<Maintenance>> GetAllAsync(CancellationToken cancellationToken);
}
