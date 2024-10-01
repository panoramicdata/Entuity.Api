using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class InventoryTests(EntuityClient client)
{
	[Fact]
	public async Task GetAll_Succeeds()
	{
		// Arrange
		var result = await client
			.Inventory
			.GetAllAsync(default);

		result.Should().NotBeNull();
	}
}
