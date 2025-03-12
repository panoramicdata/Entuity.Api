using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class UserDefinedRestPollerTests(EntuityClient client)
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
