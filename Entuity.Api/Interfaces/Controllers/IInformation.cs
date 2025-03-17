using Entuity.Api.Models.GetItems;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

/// <summary>
/// Gets information about the API.
/// </summary>
public interface IInformation
{

	[Get("/api/info")]
	Task<ApiInformation> GetAsync(CancellationToken cancellationToken);
}
