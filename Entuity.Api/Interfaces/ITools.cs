using Entuity.Api.Models;
using Refit;

namespace Entuity.Api.Interfaces;

public interface ITools
{
	[Get("/api/tools")]
	public Task<ToolsResponse> GetAllAsync(CancellationToken cancellationToken);
}
