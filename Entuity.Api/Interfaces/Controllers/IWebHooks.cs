using Entuity.Api.Collections;
using Entuity.Api.Models.WebhooksData.Get;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface IWebHooks
{
	/// <summary>
	/// Get all Custom Webhook Groups
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/webhooks/groups")]
	Task<Response<CustomWebhookGroup>> GetCustomWebhookGroupsAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Get Custom Webhook Group by Name
	/// </summary>
	/// <param name="groupName"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/webhooks/groups/{groupName}")]
	Task<CustomWebhookGroup> GetCustomWebhookGroupAsync(string groupName, CancellationToken cancellationToken);

	/// <summary>
	/// Get all Endpoints for a specific Custom Webhook Group
	/// </summary>
	/// <param name="groupName"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/webhooks/groups/{groupName}/endpoints")]
	public Task<Response<CustomWebhookGroupEndpointContainer>> GetCustomWebhookGroupEndpointsAsync(string groupName, CancellationToken cancellationToken);

	/// <summary>
	/// Gets information about events for a specific Custom Webhook Group
	/// </summary>
	/// <param name="groupId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/webhooks/groups/{groupId}/events")]
	public Task<Response<CustomWebhookGroupEventDetails>> GetCustomWebhookGroupEventDetailsAsync(int groupId, CancellationToken cancellationToken);

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
