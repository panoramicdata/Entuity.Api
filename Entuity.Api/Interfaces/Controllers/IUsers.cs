using Entuity.Api.Collections;
using Entuity.Api.Models;
using Entuity.Api.Models.GetItems;
using Entuity.Api.Models.PostItems;
using Entuity.Api.Models.UpdateItems;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;
public interface IUsers
{
	[Get("/api/users")]
	Task<Response<UserSimple>> GetAllAsync(CancellationToken cancellationToken);

	[Post("/api/users")]
	Task<Response<UserSimple>> CreateAsync([Body] UserCreate userCreate,
		CancellationToken cancellationToken);

	[Get("/api/users/{id}")]
	Task<UserDetailed> GetAsync(int id,
		CancellationToken cancellationToken);

	[Put("/api/users/{id}")]
	Task<UserDetailed> UpdateAsync(int id, [Body] UserUpdate userUpdate,
		CancellationToken cancellationToken);

	[Delete("/api/users/{id}")]
	Task<Response<UserSimple>> DeleteAsync(int id,
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
