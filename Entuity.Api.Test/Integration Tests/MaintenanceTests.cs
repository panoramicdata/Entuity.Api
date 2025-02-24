using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;
public class MaintenanceTests(EntuityClient client)
{
	[Fact]
	public async Task GetAllAsync_Succeeds()
	{
		// Arrange
		var result = await client
			.Maintenance
			.GetAllAsync(default);

		result.Should().NotBeNull();
	}
}
