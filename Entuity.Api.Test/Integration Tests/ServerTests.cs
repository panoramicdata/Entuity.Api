using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;
public class ServerTests(EntuityClient client)
{
	[Fact]
	public async Task ServerController_GetAll_Succeeds()
	{
		// Arrange
		var result = await client
			.Servers
			.GetAll(default);

		result.Should().NotBeNull();
	}
}
