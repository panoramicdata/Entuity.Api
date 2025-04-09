using Entuity.Api.Collections;
using Entuity.Api.Models;
using Entuity.Api.Models.EventsData.Get;
using Entuity.Api.Models.EventsData.Post;
using Entuity.Api.QueryParameters;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

/// <summary>
/// Events
/// see https://support.entuity.com/hc/en-us/articles/13819749116957-Events-RESTful-API
/// see https://support.entuity.com/hc/en-us/articles/13819768912669-Event-Types-RESTful-API
/// </summary>
public interface IEvents
{
	/// <summary>
	/// Returns all events
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns></returns>
	[Get("/api/events")]
	Task<EventsResponse> GetAllAsync(CancellationToken cancellationToken);


	/// <summary>
	/// Returns all events filtered by filter options
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns></returns>
	[Get("/api/events")]
	Task<EventsResponse> GetAllAsync([Query] EventsFilter parameters, CancellationToken cancellationToken);

	/// <summary>
	/// Create a new event
	/// </summary>
	/// <param name="eventCreate"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Post("/api/events")]
	Task<Message> CreateAsync([Body] EventCreate eventCreate, CancellationToken cancellationToken);

	/// <summary>
	/// Returns all Types of Events
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns></returns>
	[Get("/api/eventTypes")]
	Task<Response<EventsType>> GetAllTypesAsync(CancellationToken cancellationToken);
}