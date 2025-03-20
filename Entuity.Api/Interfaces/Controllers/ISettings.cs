using Entuity.Api.Models;
using Entuity.Api.Models.SettingsData.Get;
using Entuity.Api.Models.SettingsData.Update;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface ISettings
{
	[Get("/api/settings/globalUserSettings")]
	Task<GlobalUserSettings> GetGlobalUserSettingsAsync(CancellationToken cancellationToken);

	[Put("/api/settings/globalUserSettings")]
	Task<GlobalUserSettings> UpdateGlobalUserSettingsAsync([Body] GlobalUserSettingsUpdate settings, CancellationToken cancellationToken);

	[Post("/api/settings/globalUserSettings/resetAllUsersSettings")]
	Task<Message> ResetGlobalUsersSettingsAsync(CancellationToken cancellationToken);

	[Get("/api/settings/globalPasswordComplexitySettings")]
	Task<GlobalPasswordComplexitySettings> GetGlobalPasswordComplexitySettingsAsync(CancellationToken cancellationToken);

	[Put("/api/settings/globalPasswordComplexitySettings")]
	Task<GlobalPasswordComplexitySettings>
		UpdateGlobalPasswordComplexitySettingsAsync([Body] GlobalPasswordComplexitySettingsUpdate settings, CancellationToken cancellationToken);
}
