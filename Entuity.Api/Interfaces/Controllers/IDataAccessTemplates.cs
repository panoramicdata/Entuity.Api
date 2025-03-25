using Entuity.Api.Collections;
using Entuity.Api.Models.DataAccessTemplatesData.Get;
using Entuity.Api.Models.DataAccessTemplatesData.Post;
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

	/// <summary>
	/// Create a new Data Access Template
	/// </summary>
	/// <param name="dataAccessTemplateCreate"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Post("/api/dataAccessTemplates")]
	Task<DataAccessTemplateCreationResponse> CreateAsync([Body] DataAccessTemplateCreate dataAccessTemplateCreate, CancellationToken cancellationToken);

	/// <summary>
	/// Get detailed information about a Data Access Template by Name
	/// </summary>
	/// <param name="name"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/dataAccessTemplates/{name}")]
	Task<DataAccessTemplateDetailed> GetAsync(string name, CancellationToken cancellationToken);

	/// <summary>
	/// Delete a Data Access Template by Name
	/// </summary>
	/// <param name="name"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Delete("/api/dataAccessTemplates/{name}")]
	Task<IApiResponse> DeleteAsync(string name, CancellationToken cancellationToken);
}
