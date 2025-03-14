using Entuity.Api.Models.Collections;
using Entuity.Api.Models.ReturnItems;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface IWebHooks
{
	[Get("/api/webhooks/groups")]
	Task<Response<WebhookGroup>> GetWebhookGroupsAsync();
}
