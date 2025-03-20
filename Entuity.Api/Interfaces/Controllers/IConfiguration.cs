using Entuity.Api.Models;
using Entuity.Api.Models.Collections;
using Entuity.Api.Models.ConfigurationData.ServerGroupConfig.Get;
using Entuity.Api.Models.ConfigurationData.ServerGroupMembership.Get;
using Entuity.Api.Models.ConfigurationData.ServerGroupMembership.Post;
using Entuity.Api.Models.ConfigurationData.ServerGroups.Get;
using Entuity.Api.Models.ConfigurationData.ServerGroups.Post;
using Entuity.Api.Models.ConfigurationData.ServerGroups.Update;
using Entuity.Api.Models.ConfigurationData.ServerGroupsSummaryInfo.Get;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface IConfiguration
{
	[Get("/api/cfg/serverGroups")]
	public Task<Response<ServerGroup>> GetServerGroupsAsync(CancellationToken cancellationToken);

	[Post("/api/cfg/serverGroups")]
	public Task<ServerGroup> CreateServerGroupAsync([Body] ServerGroupCreate serverGroup, CancellationToken cancellationToken);

	[Get("/api/cfg/serverGroups/{serverGroupId}")]
	public Task<ServerGroup> GetServerGroupAsync(Guid serverGroupId, CancellationToken cancellationToken);

	[Delete("/api/cfg/serverGroups/{serverGroupId}")]
	public Task<DeleteResponse> DeleteServerGroupAsync(Guid serverGroupId, CancellationToken cancellationToken);

	[Put("/api/cfg/serverGroups/{serverGroupId}")]
	public Task<ServerGroup> UpdateServerGroupAsync(Guid serverGroupId, [Body] ServerGroupUpdate serverGroup, CancellationToken cancellationToken);

	[Get("/api/cfg/serverGroupConfig/{serverGroupId}")]
	public Task<ServerGroupConfiguration> GetServerGroupConfigurationAsync(Guid serverGroupId, CancellationToken cancellationToken);

	[Get("/api/cfg/serverGroupsSummaryInfo")]
	public Task<Response<ServerGroupSummaryInformation>> GetServerGroupsSummaryInfoAsync(CancellationToken cancellationToken);

	[Get("/api/cfg/serverGroupMembership/{serverGroupId}")]
	public Task<Response<ServerGroupMembership>> GetServerGroupMembershipsAsync(Guid serverGroupId, CancellationToken cancellationToken);

	[Post("/api/cfg/serverGroupMembership/{serverGroupId}")]
	public Task<Response<ServerGroupMembership>> AddServerGroupMembershipAsync(Guid serverGroupId, [Body] ServerGroupMembershipAdd serverGroupMembership, CancellationToken cancellationToken);

	[Post("/api/cfg/serverGroupMembership/{serverGroupId}")]
	public Task<Response<ServerGroupMembership>> RemoveServerGroupMembershipAsync(Guid serverGroupId, [Body] ServerGroupMembershipRemove serverGroupMembership, CancellationToken cancellationToken);
}
