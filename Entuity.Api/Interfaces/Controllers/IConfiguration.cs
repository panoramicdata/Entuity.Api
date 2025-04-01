using Entuity.Api.Collections;
using Entuity.Api.Models.ConfigurationData;
using Entuity.Api.Models.ConfigurationData.Configuration.Get;
using Entuity.Api.Models.ConfigurationData.Configuration.Post;
using Entuity.Api.Models.ConfigurationData.Servers.Get;
using Entuity.Api.Models.ConfigurationData.Servers.Post;
using Entuity.Api.Models.ConfigurationData.Sets.Get;
using Entuity.Api.Models.ConfigurationData.Sets.Post;
using Entuity.Api.Models.ConfigurationData.Sets.Update;
using Entuity.Api.Models.ConfigurationData.SummaryInformation.Get;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface IConfiguration
{
	#region Configuration Sets

	/// <summary>
	/// Get all Configuration Sets
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/cfg/serverGroups")]
	public Task<Response<ConfigurationSet>> GetAllConfigurationSetsAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Create new Configuration Set
	/// </summary>
	/// <param name="serverGroup"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Post("/api/cfg/serverGroups")]
	public Task<ConfigurationSet> CreateConfigurationSetAsync([Body] ConfigurationSetCreate serverGroup, CancellationToken cancellationToken);

	/// <summary>
	/// Get a Configuration Set by ID
	/// </summary>
	/// <param name="serverGroupId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/cfg/serverGroups/{serverGroupId}")]
	public Task<ConfigurationSet> GetConfigurationSetAsync(Guid serverGroupId, CancellationToken cancellationToken);

	/// <summary>
	/// Delete a Configuration Set by ID
	/// </summary>
	/// <param name="serverGroupId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Delete("/api/cfg/serverGroups/{serverGroupId}")]
	public Task<ConfigurationChangeResponse> DeleteConfigurationSetAsync(Guid serverGroupId, CancellationToken cancellationToken);

	/// <summary>
	/// Update a Configuration Set by ID
	/// </summary>
	/// <param name="serverGroupId"></param>
	/// <param name="serverGroup"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Put("/api/cfg/serverGroups/{serverGroupId}")]
	public Task<ConfigurationSet> UpdateConfigurationSetAsync(Guid serverGroupId, [Body] ConfigurationSetUpdate serverGroup, CancellationToken cancellationToken);

	#endregion

	/// <summary>
	/// Get Details for a specific Configuration Set
	/// </summary>
	/// <param name="serverGroupId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/cfg/serverGroupConfig/{serverGroupId}")]
	public Task<ConfigurationSetDetailed> GetConfigurationSetDetailsAsync(Guid serverGroupId, CancellationToken cancellationToken);

	/// <summary>
	/// Get Users in a specific Configuration Set
	/// </summary>
	/// <param name="serverGroupId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/cfg/serverGroupConfig/{serverGroupId}/users")]
	public Task<Response<ConfigurationSetUser>> GetConfigurationSetUsersAsync(Guid serverGroupId, CancellationToken cancellationToken);

	/// <summary>
	/// Add a user to a specific Configuration Set
	/// </summary>
	/// <param name="serverGroupId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Post("/api/cfg/serverGroupConfig/{serverGroupId}/users")]
	public Task<ConfigurationChangeResponse> AddUserToConfigurationSetAsync(Guid serverGroupId, [Body] ConfigurationSetUserCreate user, CancellationToken cancellationToken);

	/// <summary>
	/// Remove a user from a specific Configuration Set
	/// </summary>
	/// <param name="serverGroupId"></param>
	/// <param name="userName"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Delete("/api/cfg/serverGroupConfig/{serverGroupId}/users/{userName}")]
	public Task<ConfigurationChangeResponse> RemoveUserFromConfigurationSetAsync(Guid serverGroupId, string userName, CancellationToken cancellationToken);

	/// <summary>
	/// Get summary details about all Configuration Sets
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/cfg/serverGroupsSummaryInfo")]
	public Task<Response<ConfigurationSetSummaryInformation>> GetConfigurationSetSummaryInfoAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Get servers currently assigned to a specified Configuration Set
	/// </summary>
	/// <param name="serverGroupId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/cfg/serverGroupMembership/{serverGroupId}")]
	public Task<Response<ConfigurationSetMember>> GetConfigurationSetMembershipsAsync(Guid serverGroupId, CancellationToken cancellationToken);

	/// <summary>
	/// Add a server to a Configuration Set
	/// </summary>
	/// <param name="serverGroupId"></param>
	/// <param name="serverGroupMembership"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Post("/api/cfg/serverGroupMembership/{serverGroupId}")]
	public Task<Response<ConfigurationSetMember>> AddConfigurationSetMembersAsync(Guid serverGroupId, [Body] ConfigurationSetMembershipAdd serverGroupMembership, CancellationToken cancellationToken);

	/// <summary>
	/// Remove a server group membership from a Configuration Set
	/// </summary>
	/// <param name="serverGroupId"></param>
	/// <param name="serverGroupMembership"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Post("/api/cfg/serverGroupMembership/{serverGroupId}")]
	public Task<Response<ConfigurationSetMember>> RemoveConfigurationSetMembersAsync(Guid serverGroupId, [Body] ConfigurationSetMembershipRemove serverGroupMembership, CancellationToken cancellationToken);
}
