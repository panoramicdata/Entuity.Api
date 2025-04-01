using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.WebhooksData.Get;

/// <summary>
/// Holds information about a Custom Webhook Event
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13839341027613-Custom-Webhook-Events-RESTful-API#get'/></para>
/// </summary>
public class CustomWebhookEvent : IGetItem
{
	/// <summary>
	/// The name of this Custom Webhook Event
	/// </summary>
	public string EventName { get; set; } = string.Empty;

	/// <summary>
	/// A description of the event. This is informational only
	/// </summary>
	public string EventDescription { get; set; } = string.Empty;

	/// <summary>
	/// Unique ID of this event
	/// </summary>
	public int EventID { get; set; }

	/// <summary>
	/// The severity of the event. These include:
	/// <list type="bullet">
	/// <item>2 - Info</item>
	/// <item>4 - Minor</item>
	/// <item>6 - Major</item>
	/// <item>8 - Severe</item>
	/// <item>10 - Critical</item>
	/// </list>
	/// </summary>
	public int EventSeverity { get; set; }
}
