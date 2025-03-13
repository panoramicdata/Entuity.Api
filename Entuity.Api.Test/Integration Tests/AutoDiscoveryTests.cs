using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class AutoDiscoveryTests(EntuityClient client)
{
	[Fact]
	public async Task AutoDiscoveryController_GetAllAsync_Succeeds()
	{
		// Arrange
		var result = await client
			.AutoDiscovery
			.GetAllAsync(default);

		result.Should().NotBeNull();
	}
}
