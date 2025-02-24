using Entuity.Api.Models;
using Refit;

namespace Entuity.Api.Interfaces;
public interface IUserGroups
{
	[Get("/api/userGroups")]
	Task<Response<UserGroup>> GetAllAsync(CancellationToken cancellationToken);
}
