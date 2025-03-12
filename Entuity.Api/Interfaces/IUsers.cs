using Entuity.Api.Models;
using Refit;

namespace Entuity.Api.Interfaces;
public interface IUsers
{
	[Get("/api/users")]
	Task<Response<string, UserSimple>> GetAllAsync(CancellationToken cancellationToken);

	[Get("/api/users/{id}")]
	Task<UserDetailed> GetAsync(int id,
		CancellationToken cancellationToken);
}
