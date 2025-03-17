using Entuity.Api.Models.Collections;
using Entuity.Api.Models.GetItems;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface IFilters
{
	[Get("/api/domainFilters")]
	Task<Response<DomainFilter>> GetAllDomainFiltersAsync(CancellationToken cancellationToken);

	[Get("/api/incidentFilters")]
	Task<Response<IncidentFilterSimple>> GetAllIncidentFiltersAsync(CancellationToken cancellationToken);

	[Get("/api/incidentFilters/{id}")]
	Task<IncidentFilterDetailed> GetIncidentFilterAsync(string id, CancellationToken cancellationToken);

	[Get("/api/eventFilters")]
	Task<Response<EventFilterSimple>> GetAllEventFiltersAsync(
		CancellationToken cancellationToken);
}
