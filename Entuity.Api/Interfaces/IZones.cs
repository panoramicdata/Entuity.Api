using Entuity.Api.Models;
using Refit;

namespace Entuity.Api.Interfaces;
public interface IZones
{
	/// <summary>
	/// Get all Zones
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/zones")]
	Task<ZonesResponse> GetAllAsync(CancellationToken cancellationToken);
}
