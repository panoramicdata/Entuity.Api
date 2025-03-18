using Entuity.Api.Models;
using Entuity.Api.Models.Collections;
using Entuity.Api.Models.GetItems;
using Entuity.Api.Models.PostItems;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface IFilters
{
	[Get("/api/domainFilters")]
	Task<Response<DomainFilter>> GetAllDomainFiltersAsync(CancellationToken cancellationToken);

	[Post("/api/domainFilters")]
	Task<DomainFilterDetailed> CreateDomainFilterAsync(
		[Body] DomainFilterCreate request,
		CancellationToken cancellationToken);

	[Get("/api/domainFilters/{id}")]
	Task<DomainFilterDetailed> GetDomainFilterAsync(string id, CancellationToken cancellationToken);

	[Delete("/api/domainFilters/{id}")]
	Task<Message> DeleteDomainFilterAsync(string id,
		CancellationToken cancellationToken);


	[Get("/api/incidentFilters")]
	Task<Response<IncidentFilterSimple>> GetAllIncidentFiltersAsync(CancellationToken cancellationToken);

	[Get("/api/incidentFilters/{id}")]
	Task<IncidentFilterDetailed> GetIncidentFilterAsync(string id, CancellationToken cancellationToken);

	[Get("/api/eventFilters")]
	Task<Response<EventFilterSimple>> GetAllEventFiltersAsync(
		CancellationToken cancellationToken);
}
