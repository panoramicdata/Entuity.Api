using Entuity.Api.Collections;
using Entuity.Api.Models;
using Entuity.Api.Models.FiltersData.Get;
using Entuity.Api.Models.FiltersData.Post;
using Entuity.Api.Models.FiltersData.Update;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface IFilters
{
	/// <summary>
	/// Get all Domain Filters
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/domainFilters")]
	Task<Response<DomainFilter>> GetAllDomainFiltersAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Create new Domain Filter
	/// </summary>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Post("/api/domainFilters")]
	Task<DomainFilterDetailed> CreateDomainFilterAsync(
		[Body] DomainFilterCreate request,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get Domain Filter by ID
	/// </summary>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/domainFilters/{id}")]
	Task<DomainFilterDetailed> GetDomainFilterAsync(string id, CancellationToken cancellationToken);

	/// <summary>
	/// Update Domain Filter by ID
	/// </summary>
	/// <param name="id"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Put("/api/domainFilters/{id}")]
	Task<DomainFilterDetailed> UpdateDomainFilterAsync(string id,
		[Body] DomainFilterUpdate request,
		CancellationToken cancellationToken);

	/// <summary>
	/// Delete Domain Filter by ID
	/// </summary>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Delete("/api/domainFilters/{id}")]
	Task<Message> DeleteDomainFilterAsync(string id,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get all Incident Filters
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/incidentFilters")]
	Task<Response<IncidentFilterSimple>> GetAllIncidentFiltersAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Create new Incident Filter
	/// </summary>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Post("/api/incidentFilters")]
	Task<IncidentFilterDetailed> CreateIncidentFilterAsync(
		[Body] IncidentFilterCreate request,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get Incident Filter by ID
	/// </summary>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/incidentFilters/{id}")]
	Task<IncidentFilterDetailed> GetIncidentFilterAsync(string id, CancellationToken cancellationToken);

	/// <summary>
	/// Update Incident Filter by ID
	/// </summary>
	/// <param name="id"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Put("/api/incidentFilters/{id}")]
	Task<IncidentFilterUpdate> UpdateIncidentFilterAsync(string id,
		[Body] IncidentFilterUpdate request,
		CancellationToken cancellationToken);

	/// <summary>
	/// Delete Incident Filter by ID
	/// </summary>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
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

	[Put("/api/eventFilters/{id}")]
	Task<EventFilterDetailed> UpdateEventFilterAsync(string id,
		[Body] EventFilterUpdate request,
		CancellationToken cancellationToken);

	[Delete("/api/eventFilters/{id}")]
	Task<Message> DeleteEventFilterAsync(string id,
		CancellationToken cancellationToken);
}
