using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;
public class InformationTests(EntuityClient client) : TestFixture
{
	[Fact]
	public async Task InformationController_GetAllAsync_Succeeds()
	{
		// Arrange
		var result = await client
			.Information
			.GetAsync(default);

		result.Should().NotBeNull();
	}
}
