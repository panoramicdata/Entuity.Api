namespace Entuity.Api.Models.WebhooksData;

/// <summary>
/// Represents an Endpoint for a Custom Webhook Group
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13839312520349-Custom-Webhook-Endpoint-Details-by-Group-RESTful-API#get'/></para>
/// </summary>
public class CustomWebhookGroupEndpoint
{
	/// <summary>
	/// ID of this Endpoint
	/// </summary>
	public int EndpointID { get; set; }

	/// <summary>
	///  ID of the object on which the Endpoint URL is found
	/// </summary>
	public int ObjectID { get; set; }

	/// <summary>
	/// ID of the server on which the Custom Webhook group is hosted
	/// </summary>
	public Guid ServerID { get; set; }

	/// <summary>
	/// Maximum number of payloads that Entuity will store at any one time. 
	/// </summary>
	/// <remarks>For example, if you specify a payload maximum of 3, then the 3 most recent payloads will be stored. When a new payload is received, the oldest of the 3 saved would then be deleted and replaced with the new one. Note, the payload maximum cannot be edited if payload collection is disabled</remarks>
	public int PayloadMax { get; set; }

	/// <summary>
	/// Whether payload collection is enabled. If false, this will prevent the saving of any further payloads
	/// </summary>
	public bool SaveEnabled { get; set; }

	/// <summary>
	/// Name of the object on which the endpoint URL is found
	/// </summary>
	public string EndpointName { get; set; } = string.Empty;

	/// <summary>
	/// Name of the Custom Webhook Group in which the endpoint URL is found
	/// </summary>
	public string GroupName { get; set; } = string.Empty;

	/// <summary>
	/// The number of saved payloads
	/// </summary>
	public int PayloadCount { get; set; }

	/// <summary>
	/// Secret key, if applicable
	/// </summary>
	public string Secret { get; set; } = string.Empty;
}

