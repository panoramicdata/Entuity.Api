using Entuity.Api.Models;
using Entuity.Api.Models.Collections;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;
public interface IEventFilters
{
	[Get("/api/eventFilters")]
	Task<Response<EventFilter>> GetAllAsync(CancellationToken cancellationToken);
}
