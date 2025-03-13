using Entuity.Api.Models;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;
public interface IMaintenance
{
	[Get("/api/maintenance")]
	Task<Response<int, Maintenance>> GetAllAsync(CancellationToken cancellationToken);
}
