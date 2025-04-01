using Entuity.Api.Collections;
using Entuity.Api.Models.WebhooksData.Get;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface IWebHooks
{
	[Get("/api/webhooks/groups")]
	Task<Response<WebhookGroup>> GetWebhookGroupsAsync(CancellationToken cancellationToken);

	[Get("/api/webhooks/groups/{groupName}")]
	Task<WebhookGroup> GetWebhookGroupAsync(string groupName, CancellationToken cancellationToken);

	[Get("/api/webhooks/groups/{groupName}/endpoints")]
	public Task<Response<EndpointContainer>> GetWebhookGroupEndpointsAsync(string groupName, CancellationToken cancellationToken);

	/// <summary>
	/// Get all Custom Webhook Rules
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/webhooks/rules")]
	Task<Response<CustomWebhookRule>> GetCustomWebhookRulesAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Get a Custom Webhook Rule by Id
	/// </summary>
	/// <param name="ruleId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/webhooks/rules/{ruleId}")]
	Task<CustomWebhookRule> GetCustomWebhookRuleAsync(int ruleId, CancellationToken cancellationToken);

	[Get("/api/webhooks/endpoints")]
	Task<Response<WebhookEndpoint>> GetWebhookEndpointsAsync(CancellationToken cancellationToken);

	[Get("/api/webhooks/events")]
	Task<Response<WebhookEvent>> GetWebhookEventsAsync(CancellationToken cancellationToken);

	[Get("/api/webhooks/payloads")]
	Task<Response<WebhookPayloadCollection>> GetWebhookPayloadsAsync(CancellationToken cancellationToken);
}
