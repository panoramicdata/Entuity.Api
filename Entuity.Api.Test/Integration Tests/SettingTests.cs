using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class SettingTests(EntuityClient client)
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
}
