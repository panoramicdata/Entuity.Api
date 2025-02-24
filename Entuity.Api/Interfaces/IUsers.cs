using Entuity.Api.Models;
using Refit;

namespace Entuity.Api.Interfaces;
public interface IUsers
{
	[Get("/api/users")]
	Task<Response<string, User>> GetAllAsync(CancellationToken cancellationToken);
}
