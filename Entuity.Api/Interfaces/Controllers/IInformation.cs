using Entuity.Api.Models.InformationData.Get;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

/// <summary>
/// Gets information about the API.
/// </summary>
public interface IInformation
{
	/// <summary>
	/// Get information about the installed version of Entuity
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/info")]
	Task<EntuityVersionInformation> GetAsync(CancellationToken cancellationToken);
}
