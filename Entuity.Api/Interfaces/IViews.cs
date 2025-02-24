using Entuity.Api.Models;
using Refit;

namespace Entuity.Api.Interfaces;
public interface IViews
{
	[Get("/api/views")]
	Task<Response<View>> GetAllAsync(CancellationToken cancellationToken);
}
