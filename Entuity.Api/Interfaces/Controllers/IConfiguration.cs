using Entuity.Api.Models.Collections;
using Entuity.Api.Models.GetItems;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface IConfiguration
{
	[Get("/api/cfg/serverGroups")]
	public Task<Response<ServerGroup>> GetServerGroupsAsync(CancellationToken cancellationToken);
}
