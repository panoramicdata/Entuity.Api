using Entuity.Api.Models;
using Entuity.Api.Models.SettingsData.Get;
using Entuity.Api.Models.SettingsData.Update;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface ISettings
{
	/// <summary>
	/// Get Global User Settings
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/settings/globalUserSettings")]
	Task<GlobalUserSettings> GetGlobalUserSettingsAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Update global user settings
	/// </summary>
	/// <param name="settings"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Put("/api/settings/globalUserSettings")]
	Task<GlobalUserSettings> UpdateGlobalUserSettingsAsync([Body] GlobalUserSettingsUpdate settings, CancellationToken cancellationToken);

	/// <summary>
	/// Reset all users settings
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Post("/api/settings/globalUserSettings/resetAllUsersSettings")]
	Task<Message> ResetGlobalUsersSettingsAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Get Global Password Complexity Settings
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/settings/globalPasswordComplexitySettings")]
	Task<GlobalPasswordComplexitySettings> GetGlobalPasswordComplexitySettingsAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Update Global Password Complexity Settings
	/// </summary>
	/// <param name="settings"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Put("/api/settings/globalPasswordComplexitySettings")]
	Task<GlobalPasswordComplexitySettings>
		UpdateGlobalPasswordComplexitySettingsAsync([Body] GlobalPasswordComplexitySettingsUpdate settings, CancellationToken cancellationToken);
}
