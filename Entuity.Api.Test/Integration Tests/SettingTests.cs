using Entuity.Api.Models.UpdateItems;
using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class SettingTests(EntuityClient client) : TestFixture
{
	[Fact]
	public async Task SettingsController_GetGlobalSettingsAsync_Succeeds()
	{
		var settings = await client
			.Settings
			.GetGlobalUserSettingsAsync(default);

		settings.Should().NotBeNull();
	}

	[Fact]
	public async Task SettingsController_GetGlobalPasswordComplexitySettingsAsync_Succeeds()
	{
		var settings = await client
			.Settings
			.GetGlobalPasswordComplexitySettingsAsync(default);

		settings.Should().NotBeNull();
	}

	[Fact]
	public async Task SettingsController_UpdateGlobalPasswordComplexitySettingsAsync_ReturnsCorrectValues()
	{

		var oldSettings = await client
			.Settings
			.GetGlobalPasswordComplexitySettingsAsync(default);

		oldSettings.Should().NotBeNull();

		var newSettings = new GlobalPasswordComplexitySettingsUpdate { PwdMinLength = 5 };

		var updatedSettings = await client
			.Settings
			.UpdateGlobalPasswordComplexitySettingsAsync(newSettings, default);

		updatedSettings.Should().NotBeNull();
		updatedSettings.PwdMinLength.Should().Be(5);

		// Revert the changes

		var revertSettings = new GlobalPasswordComplexitySettingsUpdate { PwdMinLength = oldSettings.PwdMinLength };

		var revertedSettings = await client
			.Settings
			.UpdateGlobalPasswordComplexitySettingsAsync(revertSettings, default);

		revertedSettings.Should().NotBeNull();
		revertedSettings.PwdMinLength.Should().Be(oldSettings.PwdMinLength);
	}
}
