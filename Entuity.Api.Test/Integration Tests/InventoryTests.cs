using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class InventoryTests(EntuityClient client) : TestFixture
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
		// Fetch all
		var result = await client
			.Inventory
			.GetAllAsync(default);

		result.Should().NotBeNull();

		// Refetch
		foreach (var device in result.Items)
		{

			var deviceResult = await client
				.Inventory
				.GetAsync(device.Id, default);


			deviceResult.Should().NotBeNull();
		}

	}
}
