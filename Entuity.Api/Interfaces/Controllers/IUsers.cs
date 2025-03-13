using Entuity.Api.Models;
using Entuity.Api.Models.Collections;
using Entuity.Api.Models.ReturnItems;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;
public interface IUsers
{
	[Get("/api/users")]
	Task<Response<UserSimple>> GetAllAsync(CancellationToken cancellationToken);

	[Get("/api/users/{id}")]
	Task<UserDetailed> GetAsync(int id,
		CancellationToken cancellationToken);
}
