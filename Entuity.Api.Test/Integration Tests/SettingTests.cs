using Entuity.Api.Models.SettingsData.Update;
using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class SettingTests(EntuityClient client) : TestFixture
{
	[Fact]
	public async Task SettingsController_GetGlobalUserSettingsAsync_Succeeds()
	{
		var settings = await client
			.Settings
			.GetGlobalUserSettingsAsync(default);

		settings.Should().NotBeNull();
	}

	[Fact]
	public async Task SettingsController_UpdateGlobalUserSettingsAsync_Succeeds()
	{
		var oldSettings = await client
			.Settings
			.GetGlobalUserSettingsAsync(default);

		oldSettings.Should().NotBeNull();

		var newSettings = new GlobalUserSettingsUpdate { PwChangeDays = 31 };

		var response = await client
			.Settings
			.UpdateGlobalUserSettingsAsync(newSettings, default);

		response.Should().NotBeNull();
		response.PwChangeDays.Should().Be(31);

		// Revert the changes

		newSettings.PwChangeDays = oldSettings.PwChangeDays;

		var revertResponse = await client
			.Settings
			.UpdateGlobalUserSettingsAsync(newSettings, default);

		revertResponse.Should().NotBeNull();
		revertResponse.PwChangeDays.Should().Be(oldSettings.PwChangeDays);
	}

	//NOTE: Running this test seems to mess up the settings for the user running the tests
	//[Fact]
	//public async Task SettingsController_ResetGlobalUserSettingsAsync_Succeeds()
	//{
	//	var oldSettings = await client
	//		.Settings
	//		.GetGlobalUserSettingsAsync(default);

	//	oldSettings.Should().NotBeNull();

	//	var newSettings = new GlobalUserSettingsUpdate { PwChangeDays = 99 };

	//	var response = await client
	//		.Settings
	//		.UpdateGlobalUserSettingsAsync(newSettings, default);

	//	// Revert the changes
	//	newSettings.PwChangeDays = oldSettings.PwChangeDays;

	//	var revertResponse = await client
	//		.Settings
	//		.ResetGlobalUsersSettingsAsync(default);

	//	revertResponse.Should().NotBeNull();
	//}

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
