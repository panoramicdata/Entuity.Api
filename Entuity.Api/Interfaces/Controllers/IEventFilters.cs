using Entuity.Api.Models.Collections;
using Entuity.Api.Models.ReturnItems;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;
public interface IEventFilters
{
	[Get("/api/eventFilters")]
	Task<Response<EventFilter>> GetAllAsync(CancellationToken cancellationToken);
}
