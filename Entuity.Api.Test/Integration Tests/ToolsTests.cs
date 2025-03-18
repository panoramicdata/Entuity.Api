using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class ToolsTests(EntuityClient client) : TestFixture
{
	[Fact]
	public async Task ToolsController_GetAllGroupsAsync_Succeeds()
	{
		var response = await client
			.Tools
			.GetAllGroupsAsync(CancellationToken.None);

		response.Should().NotBeNull();
		response.Items.Should().NotBeEmpty();
	}
}
