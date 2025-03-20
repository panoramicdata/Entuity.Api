using Entuity.Api.Collections;
using Entuity.Api.Models.ToolsData.Get;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface ITools
{
	[Get("/api/tools")]
	public Task<Response<ToolGroup>> GetAllGroupsAsync(CancellationToken cancellationToken);
}
