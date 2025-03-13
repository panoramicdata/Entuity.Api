using Entuity.Api.Models;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;
public interface IViews
{
	[Get("/api/views")]
	Task<Response<string, View>> GetAllAsync(CancellationToken cancellationToken);
}
