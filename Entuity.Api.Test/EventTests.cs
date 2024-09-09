using FluentAssertions;

namespace Entuity.Api.Test;

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
