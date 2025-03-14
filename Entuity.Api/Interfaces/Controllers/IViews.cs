using Entuity.Api.Models.Collections;
using Entuity.Api.Models.ReturnItems;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;
public interface IViews
{
	[Get("/api/views")]
	Task<Response<View>> GetAllAsync(CancellationToken cancellationToken);

	[Get("/api/views/{id}")]
	Task<ViewDetailed> GetAsync(string id, CancellationToken cancellationToken);
}
