using Entuity.Api.Collections;
using Entuity.Api.Models;
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
	/// <summary>
	/// Get all Server Groups
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/cfg/serverGroups")]
	public Task<Response<ServerGroup>> GetServerGroupsAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Create new Server Group
	/// </summary>
	/// <param name="serverGroup"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Post("/api/cfg/serverGroups")]
	public Task<ServerGroup> CreateServerGroupAsync([Body] ServerGroupCreate serverGroup, CancellationToken cancellationToken);

	/// <summary>
	/// Get a Server Group by ID
	/// </summary>
	/// <param name="serverGroupId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/cfg/serverGroups/{serverGroupId}")]
	public Task<ServerGroup> GetServerGroupAsync(Guid serverGroupId, CancellationToken cancellationToken);

	/// <summary>
	/// Delete a Server Group by ID
	/// </summary>
	/// <param name="serverGroupId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Delete("/api/cfg/serverGroups/{serverGroupId}")]
	public Task<DeleteResponse> DeleteServerGroupAsync(Guid serverGroupId, CancellationToken cancellationToken);

	/// <summary>
	/// Update a Server Group by ID
	/// </summary>
	/// <param name="serverGroupId"></param>
	/// <param name="serverGroup"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Put("/api/cfg/serverGroups/{serverGroupId}")]
	public Task<ServerGroup> UpdateServerGroupAsync(Guid serverGroupId, [Body] ServerGroupUpdate serverGroup, CancellationToken cancellationToken);

	/// <summary>
	/// Get the server group configuration for a server group by ID
	/// </summary>
	/// <param name="serverGroupId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/cfg/serverGroupConfig/{serverGroupId}")]
	public Task<ServerGroupConfiguration> GetServerGroupConfigurationAsync(Guid serverGroupId, CancellationToken cancellationToken);

	/// <summary>
	/// Get all Server Group Summary Information
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/cfg/serverGroupsSummaryInfo")]
	public Task<Response<ServerGroupSummaryInformation>> GetServerGroupsSummaryInfoAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Get the server group memberships for a server group by ID
	/// </summary>
	/// <param name="serverGroupId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/cfg/serverGroupMembership/{serverGroupId}")]
	public Task<Response<ServerGroupMembership>> GetServerGroupMembershipsAsync(Guid serverGroupId, CancellationToken cancellationToken);

	/// <summary>
	/// Add a new server group membership for a server group by ID
	/// </summary>
	/// <param name="serverGroupId"></param>
	/// <param name="serverGroupMembership"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Post("/api/cfg/serverGroupMembership/{serverGroupId}")]
	public Task<Response<ServerGroupMembership>> AddServerGroupMembershipAsync(Guid serverGroupId, [Body] ServerGroupMembershipAdd serverGroupMembership, CancellationToken cancellationToken);

	/// <summary>
	/// Remove a server group membership for a server group by ID
	/// </summary>
	/// <param name="serverGroupId"></param>
	/// <param name="serverGroupMembership"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Post("/api/cfg/serverGroupMembership/{serverGroupId}")]
	public Task<Response<ServerGroupMembership>> RemoveServerGroupMembershipAsync(Guid serverGroupId, [Body] ServerGroupMembershipRemove serverGroupMembership, CancellationToken cancellationToken);
}
