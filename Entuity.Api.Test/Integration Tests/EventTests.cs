using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

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

	[Fact]
	public async Task GetAllTypes_Succeeds()
	{
		// Arrange
		var result = await client
			.Events
			.GetAllTypesAsync(default);

		result.Should().NotBeNull();
	}
}
