using Entuity.Api.Models.GetItems;
using Entuity.Api.Models.UpdateItems;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface ISettings
{
	[Get("/api/settings/globalUserSettings")]
	Task<GlobalUserSettings> GetGlobalUserSettingsAsync(CancellationToken cancellationToken);

	[Get("/api/settings/globalPasswordComplexitySettings")]
	Task<GlobalPasswordComplexitySettings> GetGlobalPasswordComplexitySettingsAsync(CancellationToken cancellationToken);

	[Put("/api/settings/globalPasswordComplexitySettings")]
	Task<GlobalPasswordComplexitySettings>
		UpdateGlobalPasswordComplexitySettingsAsync([Body] GlobalPasswordComplexitySettingsUpdate settings, CancellationToken cancellationToken);
}
