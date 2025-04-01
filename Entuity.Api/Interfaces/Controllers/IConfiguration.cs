using Entuity.Api.Collections;
using Entuity.Api.Models.ConfigurationData;
using Entuity.Api.Models.ConfigurationData.ServerGroupMembership.Get;
using Entuity.Api.Models.ConfigurationData.ServerGroupMembership.Post;
using Entuity.Api.Models.ConfigurationData.ServerGroupsSummaryInfo.Get;
using Entuity.Api.Models.ConfigurationData.Sets.Get;
using Entuity.Api.Models.ConfigurationData.Sets.Post;
using Entuity.Api.Models.ConfigurationData.Sets.Update;
using Entuity.Api.Models.ConfigurationData.SummaryInformation.Get;
using Entuity.Api.Models.ConfigurationData.SummaryInformation.Post;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface IConfiguration
{
	#region Configuration Sets

	/// <summary>
	/// Get all Server Group configuration sets
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/cfg/serverGroups")]
	public Task<Response<ConfigurationSet>> GetAllConfigurationSetsAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Create new Server Group configuration set
	/// </summary>
	/// <param name="serverGroup"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Post("/api/cfg/serverGroups")]
	public Task<ConfigurationSet> CreateConfigurationSetAsync([Body] ConfigurationSetCreate serverGroup, CancellationToken cancellationToken);

	/// <summary>
	/// Get a Server Group configuration set by ID
	/// </summary>
	/// <param name="serverGroupId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/cfg/serverGroups/{serverGroupId}")]
	public Task<ConfigurationSet> GetConfigurationSetAsync(Guid serverGroupId, CancellationToken cancellationToken);

	/// <summary>
	/// Delete a Server Group configuration set by ID
	/// </summary>
	/// <param name="serverGroupId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Delete("/api/cfg/serverGroups/{serverGroupId}")]
	public Task<ConfigurationChangeResponse> DeleteConfigurationSetAsync(Guid serverGroupId, CancellationToken cancellationToken);

	/// <summary>
	/// Update a Server Group config set by ID
	/// </summary>
	/// <param name="serverGroupId"></param>
	/// <param name="serverGroup"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Put("/api/cfg/serverGroups/{serverGroupId}")]
	public Task<ConfigurationSet> UpdateConfigurationSetAsync(Guid serverGroupId, [Body] ConfigurationSetUpdate serverGroup, CancellationToken cancellationToken);

	#endregion

	/// <summary>
	/// Get the server group configuration for a server group by ID
	/// </summary>
	/// <param name="serverGroupId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/cfg/serverGroupConfig/{serverGroupId}")]
	public Task<ConfigurationSetDetailed> GetServerGroupConfigurationAsync(Guid serverGroupId, CancellationToken cancellationToken);

	/// <summary>
	/// Get the users for a server group config set by ID
	/// </summary>
	/// <param name="serverGroupId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/cfg/serverGroupConfig/{serverGroupId}/users")]
	public Task<Response<ConfigurationSetUser>> GetServerGroupUsersAsync(Guid serverGroupId, CancellationToken cancellationToken);

	/// <summary>
	/// Create a user on a server group config set by server ID
	/// </summary>
	/// <param name="serverGroupId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Post("/api/cfg/serverGroupConfig/{serverGroupId}/users")]
	public Task<ConfigurationChangeResponse> CreateUserOnServerGroupAsync(Guid serverGroupId, [Body] ConfigurationSetUserCreate user, CancellationToken cancellationToken);

	/// <summary>
	/// Delete a user from a server group config set by ID
	/// </summary>
	/// <param name="serverGroupId"></param>
	/// <param name="userName"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Delete("/api/cfg/serverGroupConfig/{serverGroupId}/users/{userName}")]
	public Task<ConfigurationChangeResponse> DeleteUserOnServerGroupAsync(Guid serverGroupId, string userName, CancellationToken cancellationToken);



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
