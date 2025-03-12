using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class ToolsTests(EntuityClient client)
{
	[Fact]
	public async Task ToolsController_GetAllAsync_Succeeds()
	{
		var response = await client
			.Tools
			.GetAllAsync(CancellationToken.None);

		response.Should().NotBeNull();
		response.Items.Should().NotBeEmpty();
	}
}
