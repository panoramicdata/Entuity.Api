using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class WebHookTests(EntuityClient client)
{
	[Fact]
	public async Task WebHooksController_GetWebHookGroupsAsync_Succeeds()
	{
		var webHooks = await client
			.WebHooks
			.GetWebhookGroupsAsync();

		webHooks.Should().NotBeNull();
	}
}
