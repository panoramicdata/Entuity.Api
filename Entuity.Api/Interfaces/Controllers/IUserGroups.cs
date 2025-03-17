using Entuity.Api.Models.Collections;
using Entuity.Api.Models.ReturnItems;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;
public interface IUserGroups
{
	[Get("/api/userGroups")]
	Task<Response<UserGroup>> GetAllAsync(CancellationToken cancellationToken);

	[Get("/api/userGroups/{id}/tools")]
	Task<Response<UserGroupTool>> GetToolsAsync(int id, CancellationToken cancellationToken);
}
