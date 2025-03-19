using Entuity.Api.Models.Collections;
using Entuity.Api.Models.GetItems;
using Entuity.Api.Models.PostItems;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;
public interface IViews
{
	[Get("/api/views")]
	Task<Response<View>> GetAllAsync(CancellationToken cancellationToken);

	[Post("/api/views")]
	Task<Response<View>> CreateAsync([Body] ViewCreate view, CancellationToken cancellationToken);

	[Get("/api/views/{id}")]
	Task<ViewDetailed> GetAsync(string id, CancellationToken cancellationToken);

	[Delete("/api/views/{id}")]
	Task<IApiResponse> DeleteAsync(string id, CancellationToken cancellationToken);

	[Get("/api/views/{id}/objects")]
	Task<Response<ViewObject>> GetObjectsAsync(string id, CancellationToken cancellationToken);
}
