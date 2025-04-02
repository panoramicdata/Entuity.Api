using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.WebhooksData.Get;

/// <summary>
/// Holds information about an event that occurred on a Custom Webhook Group
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13839344429853-Custom-Webhook-Event-Details-by-Group-RESTful-API#get'/></para>
/// </summary>
public class CustomWebhookGroupEventDetails : IGetItem
{
	/// <summary>
	/// The unique ID of the Custom Webhook Group for which these Events occurred
	/// </summary>
	public int ContainerID { get; set; }

	/// <inheritdoc cref="CustomWebhookEvent"/>
	public IEnumerable<CustomWebhookEvent> Events { get; set; } = [];
}


