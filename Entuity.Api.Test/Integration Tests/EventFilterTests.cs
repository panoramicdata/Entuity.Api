using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;
public class EventFilterTests(EntuityClient client)
{
	[Fact]
	public async Task EventFiltersController_GetAllAsync_Succeeds()
	{
		// Arrange
		var result = await client
			.EventFilters
			.GetAllAsync(default);

		result.Should().NotBeNull();
	}
}
