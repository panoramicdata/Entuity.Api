using Entuity.Api.Models.Collections;
using Entuity.Api.Models.GetItems;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface ITools
{
	[Get("/api/tools")]
	public Task<Response<ToolGroup>> GetAllGroupsAsync(CancellationToken cancellationToken);
}
