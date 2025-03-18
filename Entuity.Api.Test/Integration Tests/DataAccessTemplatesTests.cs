using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;
public class DataAccessTemplatesTests(EntuityClient client) : TestFixture
{
	[Fact]
	public async Task DataAccessTemplatesController_GetAllAsync_Succeeds()
	{
		// Arrange
		var result = await client
			.DataAccessTemplates
			.GetAllAsync(default);

		result.Should().NotBeNull();
	}
}
