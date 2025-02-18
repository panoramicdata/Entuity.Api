using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class ZonesTests(EntuityClient client)
{
	[Fact]
	public async Task ZonesController_GetAllAsync_Succeeds()
	{
		// Arrange
		var result = await client
			.Zones
			.GetAllAsync(default);

		result.Should().NotBeNull();
	}
}
