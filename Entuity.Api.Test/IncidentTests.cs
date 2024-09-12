using FluentAssertions;

namespace Entuity.Api.Test;

public class IncidentTests(EntuityClient client)
{
	[Fact]
	public async Task GetAll_Succeeds()
	{
		// Arrange
		var result = await client
			.Incidents
			.GetAllAsync(default);

		result.Should().NotBeNull();
	}
}
