using Entuity.Api.Models.WebhooksData.Post;
using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class WebHookTests(EntuityClient client) : TestFixture
{
	[Fact]
	public async Task WebHooksController_GetWebHookGroupsAsync_Succeeds()
	{
		var webHooks = await client
			.WebHooks
			.GetCustomWebhookGroupsAsync(default);

		webHooks.Should().NotBeNull();
	}

	[Fact]
	public async Task WebHooksController_GetCustomWebhookGroupAsync_Succeeds()
	{
		var webHooks = await client
			.WebHooks
			.GetCustomWebhookGroupsAsync(default);

		webHooks.Should().NotBeNull();

		foreach (var webHook in webHooks.Items)
		{
			var group = await client
				.WebHooks
				.GetCustomWebhookGroupAsync(webHook.GroupName, default);

			group.Should().NotBeNull();
		}
	}

	[Fact]
	public async Task WebHookController_CreateCustomWebhookGroupAsync_Succeeds()
	{
		var webHookGroup = new CustomWebhookGroupCreate
		{
			GroupName = "TestGroup",
			AuthenticationMethod = new()
			{
				AuthKey = "not used",
				AuthType = "1",
			}
		};
		var groupResponse = await client
			.WebHooks
			.CreateCustomWebhookGroupAsync(webHookGroup, default);

		groupResponse.Should().NotBeNull();

		// Get all Custom Webhook groups

		var webHooks = await client
			.WebHooks
			.GetCustomWebhookGroupsAsync(default);

		webHooks.Should().NotBeNull();

		// Find the created group
		var createdGroup = webHooks.Items
			.FirstOrDefault(g => g.GroupName == webHookGroup.GroupName);

		createdGroup.Should().NotBeNull();

		// Delete
		await client
			.WebHooks
			.DeleteCustomWebhookGroupAsync(webHookGroup.GroupName, default);
	}

	[Fact]
	public async Task WebHookController_GetCustomWebhookGroupEndpointsAsync_Succeeds()
	{
		// Get all Webhooks
		var webHooks = await client
			.WebHooks
			.GetCustomWebhookGroupsAsync(default);

		webHooks.Should().NotBeNull();

		// Get all Endpoints for each Webhook
		foreach (var webHook in webHooks.Items)
		{
			var endpoints = await client
				.WebHooks
				.GetCustomWebhookGroupEndpointsAsync(webHook.GroupName, default);

			endpoints.Should().NotBeNull();
		}
	}

	[Fact]
	public async Task WebHooksController_GetCustomWebhookRulesAsync_Succeeds()
	{
		var webHookRules = await client
			.WebHooks
			.GetCustomWebhookRulesAsync(default);

		webHookRules.Should().NotBeNull();
	}

	[Fact]
	public async Task WebHooksController_GetCustomWebhookRuleDetailsAsync_Succeeds()
	{
		var webHookRules = await client
			.WebHooks
			.GetCustomWebhookRulesAsync(default);

		webHookRules.Should().NotBeNull();

		foreach (var webHookRule in webHookRules.Items)
		{
			var rule = await client
				.WebHooks
				.GetCustomWebhookRuleDetailsAsync(webHookRule.RuleID, default);
			rule.Should().NotBeNull();
		}
	}

	[Fact]
	public async Task WebHooksController_GetCustomWebhookEndpointsAsync_Succeeds()
	{
		var webHookEndpoints = await client
			.WebHooks
			.GetCustomWebhookEndpointsAsync(default);

		webHookEndpoints.Should().NotBeNull();
	}

	[Fact]
	public async Task WebHooksController_GetAllCustomWebhookEventsAsync_Succeeds()
	{
		var webHookEvents = await client
			.WebHooks
			.GetAllCustomWebhookEventsAsync(default);

		webHookEvents.Should().NotBeNull();
	}

	[Fact]
	public async Task WebHookController_GetAllCustomWebhookPayloadsAsync_Succeeds()
	{
		var webHookPayloads = await client
			.WebHooks
			.GetAllCustomWebhookPayloadsAsync(default);

		webHookPayloads.Should().NotBeNull();
	}

	[Fact]
	public async Task WebHookController_GetCustomWebhookGroupEventDetailsAsync_Succeeds()
	{
		// Get all Webhooks
		var webHooks = await client
			.WebHooks
			.GetCustomWebhookGroupsAsync(default);

		webHooks.Should().NotBeNull();

		var firstGroup = webHooks.Items.FirstOrDefault();

		firstGroup.Should().NotBeNull();

		var events = await client
			.WebHooks
			.GetCustomWebhookGroupEventDetailsAsync(firstGroup!.GroupID, default);

		events.Should().NotBeNull();
	}
}
