using Entuity.Api.Models;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;
public interface IEventFilters
{
	[Get("/api/eventFilters")]
	Task<Response<string, EventFilter>> GetAllAsync(CancellationToken cancellationToken);
}
