using Entuity.Api.Models;
using Refit;

namespace Entuity.Api.Interfaces;
public interface IViews
{
	[Get("/api/views")]
	Task<Response<string, View>> GetAllAsync(CancellationToken cancellationToken);
}
