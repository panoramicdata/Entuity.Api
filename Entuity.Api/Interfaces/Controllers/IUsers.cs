using Entuity.Api.Models;
using Entuity.Api.Models.Collections;
using Entuity.Api.Models.GetItems;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;
public interface IUsers
{
	[Get("/api/users")]
	Task<Response<UserSimple>> GetAllAsync(CancellationToken cancellationToken);

	[Get("/api/users/{id}")]
	Task<UserDetailed> GetAsync(int id,
		CancellationToken cancellationToken);

	/// <summary>
	/// Returns a List of the names of the groups that a specific user is the member of.
	/// </summary>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/users/{id}/groups")]
	Task<BasicResponse<string>> GetUsersGroup(int id,
		CancellationToken cancellationToken);
}
