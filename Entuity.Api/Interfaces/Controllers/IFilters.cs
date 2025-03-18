using Entuity.Api.Models;
using Entuity.Api.Models.Collections;
using Entuity.Api.Models.GetItems;
using Entuity.Api.Models.PostItems;
using Entuity.Api.Models.UpdateItems;
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

	[Put("/api/domainFilters/{id}")]
	Task<DomainFilterDetailed> UpdateDomainFilterAsync(string id,
		[Body] DomainFilterUpdate request,
		CancellationToken cancellationToken);

	[Delete("/api/domainFilters/{id}")]
	Task<Message> DeleteDomainFilterAsync(string id,
		CancellationToken cancellationToken);


	[Get("/api/incidentFilters")]
	Task<Response<IncidentFilterSimple>> GetAllIncidentFiltersAsync(CancellationToken cancellationToken);

	[Post("/api/incidentFilters")]
	Task<IncidentFilterDetailed> CreateIncidentFilterAsync(
		[Body] IncidentFilterCreate request,
		CancellationToken cancellationToken);

	[Get("/api/incidentFilters/{id}")]
	Task<IncidentFilterDetailed> GetIncidentFilterAsync(string id, CancellationToken cancellationToken);

	[Put("/api/incidentFilters/{id}")]
	Task<IncidentFilterUpdate> UpdateIncidentFilterAsync(string id,
		[Body] IncidentFilterUpdate request,
		CancellationToken cancellationToken);

	[Delete("/api/incidentFilters/{id}")]
	Task<Message> DeleteIncidentFilterAsync(string id,
		CancellationToken cancellationToken);

	[Get("/api/eventFilters")]
	Task<Response<EventFilterSimple>> GetAllEventFiltersAsync(
		CancellationToken cancellationToken);

	[Post("/api/eventFilters")]
	Task<EventFilterDetailed> CreateEventFilterAsync(
		[Body] EventFilterCreate request,
		CancellationToken cancellationToken);

	[Get("/api/eventFilters/{id}")]
	Task<EventFilterDetailed> GetEventFilterAsync(string id,
		CancellationToken cancellationToken);

	[Delete("/api/eventFilters/{id}")]
	Task<Message> DeleteEventFilterAsync(string id,
		CancellationToken cancellationToken);
}
