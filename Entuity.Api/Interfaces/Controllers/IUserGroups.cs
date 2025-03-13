using Entuity.Api.Models;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;
public interface IUserGroups
{
	[Get("/api/userGroups")]
	Task<Response<string, UserGroup>> GetAllAsync(CancellationToken cancellationToken);
}
