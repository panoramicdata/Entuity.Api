using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class UserDefinedRestPollerTests(EntuityClient client) : TestFixture
{
	[Fact]
	public async Task UserDefinedRestPollersController_GetAllAsync_Succeeds()
	{
		var pollers = await client
			.UserDefinedRestPollers
			.GetAllAsync(default);

		pollers.Should().NotBeNull();
		pollers.Items.Should().NotBeEmpty();
	}
}
