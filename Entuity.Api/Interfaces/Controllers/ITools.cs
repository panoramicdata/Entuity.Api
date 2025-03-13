using Entuity.Api.Models;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface ITools
{
	[Get("/api/tools")]
	public Task<ToolsResponse> GetAllAsync(CancellationToken cancellationToken);
}
