using Entuity.Api.Models.Collections;
using Entuity.Api.Models.ReturnItems;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface IWebHooks
{
	[Get("/api/webhooks/groups")]
	Task<Response<WebhookGroup>> GetWebhookGroupsAsync(CancellationToken cancellationToken);

	[Get("/api/webhooks/groups/{groupName}")]
	Task<WebhookGroup> GetWebhookGroupAsync(string groupName, CancellationToken cancellationToken);

	[Get("/api/webhooks/rules")]
	Task<Response<WebhookRule>> GetWebhookRulesAsync(CancellationToken cancellationToken);

	[Get("/api/webhooks/rules/{ruleId}")]
	Task<WebhookRule> GetWebhookRuleAsync(int ruleId, CancellationToken cancellationToken);

	[Get("/api/webhooks/endpoints")]
	Task<Response<WebhookEndpoint>> GetWebhookEndpointsAsync(CancellationToken cancellationToken);
}
