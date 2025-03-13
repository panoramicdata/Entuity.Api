using Entuity.Api.Models.Collections;
using Entuity.Api.Models.ReturnItems;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface IFilters
{
	[Get("/api/domainFilters")]
	Task<Response<DomainFilter>> GetAllDomainFiltersAsync(CancellationToken cancellationToken);

	[Get("/api/incidentFilters")]
	Task<Response<IncidentFilter>> GetAllIncidentFiltersAsync(CancellationToken cancellationToken);

	[Get("/api/eventFilters")]
	Task<Response<EventFilter>> GetAllEventFiltersAsync(
		CancellationToken cancellationToken);
}
