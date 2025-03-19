using Entuity.Api.Models.Collections;
using Entuity.Api.Models.GetItems;
using Entuity.Api.Models.PostItems;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;
public interface IUserGroups
{
	[Get("/api/userGroups")]
	Task<Response<UserGroup>> GetAllAsync(CancellationToken cancellationToken);

	[Post("/api/userGroups")]
	Task<Response<UserGroup>> CreateAsync([Body] UserGroupCreate userGroup, CancellationToken cancellationToken);

	[Delete("/api/userGroups/{id}")]
	Task<Response<UserGroup>> DeleteAsync(int id, CancellationToken cancellationToken);

	[Get("/api/userGroups/{id}/tools")]
	Task<Response<UserGroupTool>> GetToolsAsync(int id, CancellationToken cancellationToken);
}
