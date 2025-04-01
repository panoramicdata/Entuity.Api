namespace Entuity.Api.Models.WebhooksData;


/// <summary>
/// Represents a payload associated with a custom Webhook.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13839555060253-Custom-Webhooks-List-Payloads-RESTful-API#get'/></para>
/// </summary>
public class CustomWebhookPayload
{
	/// <summary>
	/// The data of the Payload
	/// </summary>
	public string Payload { get; set; } = string.Empty;

	/// <summary>
	/// Unique ID of the Custom Webhook endpoint that received this payload
	/// </summary>
	public int EndpointID { get; set; }

	/// <summary>
	/// The name of the Custom Webhook endpoint that received this payload
	/// </summary>
	public string EndpointName { get; set; } = string.Empty;

	/// <summary>
	/// The Stormworks identifier for the managed device from which this Webhook was sent
	/// </summary>
	public int ObjectID { get; set; }

	/// <summary>
	/// The Payload Media Type. E.g. json
	/// </summary>
	public string MediaType { get; set; } = string.Empty;

	/// <summary>
	/// When this payload was recieved
	/// </summary>
	public int Timestamp { get; set; }

	/// <summary>
	/// The name of the Custom Webhook Group on which the Endpoint that recieved this payload is a member
	/// </summary>
	public string GroupName { get; set; } = string.Empty;

	/// <summary>
	/// Unique ID of this payload
	/// </summary>
	public int PayloadID { get; set; }
}

