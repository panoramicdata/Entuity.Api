using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class SettingTests(EntuityClient client)
{
	[Fact]
	public async Task SettingsController_GetGlobalSettingsAsync_Succeeds()
	{
		var settings = await client
			.Settings
			.GetGlobalUserSettingsAsync();

		settings.Should().NotBeNull();
	}
}
