using FluentAssertions;

namespace Entuity.Api.Test;

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

public class EventTests(EntuityClient client)
{
	[Fact]
	public async Task GetAll_Succeeds()
	{
		// Arrange
		var result = await client
			.Events
			.GetAllAsync(default);

		result.Should().NotBeNull();
	}
}