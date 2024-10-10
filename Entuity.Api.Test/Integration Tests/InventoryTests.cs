using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class InventoryTests(EntuityClient client)
{
	[Fact]
	public async Task GetAllAsync_Succeeds()
	{
		// Arrange
		var result = await client
			.Inventory
			.GetAllAsync(default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetAsync_GivenId_Succeeds()
	{
		// Arrange
		var result = await client
			.Inventory
			.GetAsync("anid", default);

		result.Should().NotBeNull();
	}
}
