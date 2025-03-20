using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.WebhooksData.Get;

public class WebhookPayloadCollection : List<WebhookPayload>, IGetItem;
