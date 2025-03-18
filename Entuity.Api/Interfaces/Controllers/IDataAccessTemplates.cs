using Entuity.Api.Models;
using Entuity.Api.Models.Collections;
using Entuity.Api.Models.GetItems;
using Entuity.Api.Models.PostItems;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

/// <summary>
/// Data Access Templates
/// see https://support.entuity.com/hc/en-us/articles/13830425214749-Data-Access-Templates-Management-Listing-and-Creating-RESTful-API#get
/// </summary>
public interface IDataAccessTemplates
{
	/// <summary>
	/// Returns all Data Access Templates
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns></returns>
	[Get("/api/dataAccessTemplates")]
	Task<Response<DataAccessTemplate>> GetAllAsync(CancellationToken cancellationToken);

	[Post("/api/dataAccessTemplates")]
	Task<DataAccessTemplateCreationResponse> CreateAsync([Body] DataAccessTemplateCreate dataAccessTemplateCreate, CancellationToken cancellationToken);

	[Delete("/api/dataAccessTemplates/{name}")]
	Task<IApiResponse> DeleteAsync(string name, CancellationToken cancellationToken);
}
