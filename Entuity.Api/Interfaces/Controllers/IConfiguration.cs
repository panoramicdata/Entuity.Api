using Entuity.Api.Models;
using Entuity.Api.Models.Collections;
using Entuity.Api.Models.GetItems;
using Entuity.Api.Models.PostItems;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface IConfiguration
{
	[Get("/api/cfg/serverGroups")]
	public Task<Response<ServerGroup>> GetServerGroupsAsync(CancellationToken cancellationToken);

	[Post("/api/cfg/serverGroups")]
	public Task<ServerGroup> CreateServerGroupAsync([Body] ServerGroupCreate serverGroup, CancellationToken cancellationToken);

	[Delete("/api/cfg/serverGroups/{serverGroupId}")]
	public Task<DeleteResponse> DeleteServerGroupAsync(Guid serverGroupId, CancellationToken cancellationToken);
}
