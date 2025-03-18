using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class WebHookTests(EntuityClient client) : TestFixture
{
	[Fact]
	public async Task WebHooksController_GetWebHookGroupsAsync_Succeeds()
	{
		var webHooks = await client
			.WebHooks
			.GetWebhookGroupsAsync(default);

		webHooks.Should().NotBeNull();
	}

	[Fact]
	public async Task WebHooksController_GetWebHookGroupAsync_Succeeds()
	{
		var webHooks = await client
			.WebHooks
			.GetWebhookGroupsAsync(default);

		webHooks.Should().NotBeNull();

		foreach (var webHook in webHooks.Items)
		{
			var group = await client
				.WebHooks
				.GetWebhookGroupAsync(webHook.GroupName, default);

			group.Should().NotBeNull();
		}
	}

	[Fact]
	public async Task WebHookController_GetWebHookEndpointsAsync_Succeeds()
	{
		// Get all Webhooks
		var webHooks = await client
			.WebHooks
			.GetWebhookGroupsAsync(default);

		webHooks.Should().NotBeNull();

		// Get all Endpoints for each Webhook
		foreach (var webHook in webHooks.Items)
		{
			var endpoints = await client
				.WebHooks
				.GetWebhookGroupEndpointsAsync(webHook.GroupName, default);

			endpoints.Should().NotBeNull();
		}
	}

	[Fact]
	public async Task WebHooksController_GetWebHookRulesAsync_Succeeds()
	{
		var webHookRules = await client
			.WebHooks
			.GetWebhookRulesAsync(default);

		webHookRules.Should().NotBeNull();
	}

	[Fact]
	public async Task WebHooksController_GetWebHookAsync_Succeeds()
	{
		var webHookRules = await client
			.WebHooks
			.GetWebhookRulesAsync(default);

		webHookRules.Should().NotBeNull();

		foreach (var webHookRule in webHookRules.Items)
		{
			var rule = await client
				.WebHooks
				.GetWebhookRuleAsync(webHookRule.RuleID, default);
			rule.Should().NotBeNull();
		}
	}

	[Fact]
	public async Task WebHooksController_GetWebHookEndpointsAsync_Succeeds()
	{
		var webHookEndpoints = await client
			.WebHooks
			.GetWebhookEndpointsAsync(default);

		webHookEndpoints.Should().NotBeNull();
	}

	[Fact]
	public async Task WebHooksController_GetWebHookEventsAsync_Succeeds()
	{
		var webHookEvents = await client
			.WebHooks
			.GetWebhookEventsAsync(default);

		webHookEvents.Should().NotBeNull();
	}
}
