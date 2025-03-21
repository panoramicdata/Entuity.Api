using Entuity.Api.Collections;
using Entuity.Api.Models.ViewsData.Get;
using Entuity.Api.Models.ViewsData.Post;
using Entuity.Api.Models.ViewsData.Update;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;
public interface IViews
{
	/// <summary>
	/// Returns all Views
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/views")]
	Task<Response<View>> GetAllAsync(CancellationToken cancellationToken);

	[Post("/api/views")]
	Task<Response<View>> CreateAsync([Body] ViewCreate view, CancellationToken cancellationToken);

	/// <summary>
	/// Returns a View by id
	/// </summary>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/views/{id}")]
	Task<ViewDetailed> GetAsync(string id, CancellationToken cancellationToken);

	/// <summary>
	/// Updates a View by id, returns the updated View
	/// </summary>
	/// <param name="id"></param>
	/// <param name="view"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Put("/api/views/{id}")]
	Task<ViewDetailed> UpdateAsync(string id, [Body] ViewUpdate view, CancellationToken cancellationToken);

	/// <summary>
	/// Deletes a View by id
	/// </summary>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Delete("/api/views/{id}")]
	Task<IApiResponse> DeleteAsync(string id, CancellationToken cancellationToken);

	/// <summary>
	/// Returns all objects in a View
	/// </summary>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/views/{id}/objects")]
	Task<Response<ViewObject>> GetObjectsAsync(string id, CancellationToken cancellationToken);

	/// <summary>
	/// Adds a List of objects to a View by id
	/// </summary>
	/// <param name="viewId"></param>
	/// <param name="id">List of IDs of objects to add</param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Put("/api/views/{viewId}/objects")]
	Task<Response<ViewObject>> UpdateObjectsAsync(string viewId, [Query(CollectionFormat.Multi)] List<int> id, CancellationToken cancellationToken);

	/// <summary>
	/// Deletes a List of objects from a View matching the given IDs
	/// </summary>
	/// <param name="viewId"></param>
	/// <param name="id">List of IDs of objects to remove</param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Delete("/api/views/{viewId}/objects")]
	Task<Response<ViewObject>> DeleteObjectsAsync(string viewId, [Query(CollectionFormat.Multi)] List<int> id, CancellationToken cancellationToken);
}
