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
	/// Get details about a Custom Webhook Rule by Id
	/// </summary>
	/// <param name="ruleId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/webhooks/rules/{ruleId}")]
	Task<CustomWebhookRule> GetCustomWebhookRuleDetailsAsync(int ruleId, CancellationToken cancellationToken);

	/// <summary>
	/// Get all Custom Webhook Endpoints
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/webhooks/endpoints")]
	Task<Response<CustomWebhookEndpoint>> GetCustomWebhookEndpointsAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Get all Custom Webhook Events
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/webhooks/events")]
	Task<Response<CustomWebhookEvent>> GetAllCustomWebhookEventsAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Get all Custom Webhook Payloads
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/webhooks/payloads")]
	Task<Response<CustomWebhookPayloadCollection>> GetAllCustomWebhookPayloadsAsync(CancellationToken cancellationToken);
}
