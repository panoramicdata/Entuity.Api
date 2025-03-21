using Entuity.Api.Collections;
using Entuity.Api.Models.UserGroupsData.Get;
using Entuity.Api.Models.UserGroupsData.Post;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;
public interface IUserGroups
{
	/// <summary>
	/// Get all User Groups
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/userGroups")]
	Task<Response<UserGroup>> GetAllAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Get a User Group by Id
	/// </summary>
	/// <param name="userGroup"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Post("/api/userGroups")]
	Task<Response<UserGroup>> CreateAsync([Body] UserGroupCreate userGroup, CancellationToken cancellationToken);

	/// <summary>
	/// Delete a User Group by Id
	/// </summary>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Delete("/api/userGroups/{id}")]
	Task<Response<UserGroup>> DeleteAsync(int id, CancellationToken cancellationToken);


	/// <summary>
	/// Get all tools for a User Group
	/// </summary>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/userGroups/{id}/tools")]
	Task<Response<UserGroupTool>> GetToolsAsync(int id, CancellationToken cancellationToken);
}
