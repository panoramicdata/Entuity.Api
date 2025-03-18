using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.GetItems;

public class WebhookPayloadCollection : List<WebhookPayload>, IGetItem;
