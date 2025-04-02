namespace Entuity.Api.Models.WebhooksData.Get;

/// <summary>
/// Holds information about an event that has occurred for a Custom Webhook Group
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13839344429853-Custom-Webhook-Event-Details-by-Group-RESTful-API#get'/></para>
/// </summary>
public class CustomWebhookGroupEvent
{
	/// <summary>
	/// The name of the Custom Webhook Event
	/// </summary>
	public string EventName { get; set; } = string.Empty;

	/// <summary>
	/// Description of the event. This is informational only
	/// </summary>
	public string EventDescription { get; set; } = string.Empty;

	/// <summary>
	/// Unique ID of the event
	/// </summary>
	public int EventID { get; set; }

	/// <summary>
	/// The severity of the event. This is one of the following:
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


