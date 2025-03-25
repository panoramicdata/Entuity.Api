using Entuity.Api.Collections;
using Entuity.Api.Models.AutoDiscoveryData.Get;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface IAutoDiscovery
{
	/// <summary>
	/// Get all AutoDiscovery data
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/autodiscovery")]
	Task<SettingsResponse<AutoDiscovery>> GetAllAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Get all AutoDiscovery profiles
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/autodiscoveryProfiles")]
	Task<SettingsResponse<AutoDiscoveryProfile>> GetAllProfilesAsync(CancellationToken cancellationToken);
}
