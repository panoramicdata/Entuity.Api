using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class ConfigurationTests(EntuityClient client)
{
	[Fact]
	public async Task ConfigurationController_GetServerGroupsAsync_Succeeds()
	{
		var response = await client
			.Configuration
			.GetServerGroupsAsync(default);

		response.Should().NotBeNull();
	}
}
