using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.WebhooksData.Get;

/// <summary>
/// A Collection of Custom Webhook Payloads
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13839555060253-Custom-Webhooks-List-Payloads-RESTful-API#get'/></para>
/// </summary>
public class CustomWebhookPayloadCollection : List<CustomWebhookPayload>, IGetItem;
