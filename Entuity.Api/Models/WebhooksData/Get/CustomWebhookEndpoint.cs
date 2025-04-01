using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.WebhooksData.Get;

/// <summary>
/// Holds information about a Custom Webhook's Endpoint
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13839234791837-Custom-Webhook-Endpoints-RESTful-API#get'/></para>
/// </summary>
public class CustomWebhookEndpoint : IGetItem
{
	/// <summary>
	/// Unique ID of the endpoint
	/// </summary>
	public int EndpointID { get; set; }

	/// <summary>
	/// ID of the object on which the endpoint URL is found
	/// </summary>
	public int ObjectID { get; set; }

	/// <summary>
	/// Unique ID of the server on which the endpoint object is found
	/// </summary>
	public Guid ServerID { get; set; }

	/// <summary>
	/// Outlines the maximum number of payloads that Entuity will store at any one time
	/// </summary>
	/// <remarks>
	/// For example, if you specify a payload maximum of 3, then the 3 most recent payloads will be stored. When a new payload is received, the oldest of the 3 saved would then be deleted and replaced with the new one. Note, the payload maximum cannot be edited if payload collection is disabled. <para>See <a href='https://support.entuity.com/hc/en-us/articles/13839234791837-Custom-Webhook-Endpoints-RESTful-API#get'>documentation</a> for more details</para></remarks>
	public int PayloadMax { get; set; }

	/// <summary>
	/// Whether the collection of payloads in enabled. If disabled, no future payloads will be stored
	/// </summary>
	public bool SaveEnabled { get; set; }

	/// <summary>
	/// Name of the object on which the endpoint URL is found
	/// </summary>
	public string EndpointName { get; set; } = string.Empty;

	/// <summary>
	/// Name of the Webhook group to which this endpoint belongs
	/// </summary>
	public string GroupName { get; set; } = string.Empty;

	/// <summary>
	/// The amount of Payloads saved
	/// </summary>
	public int PayloadCount { get; set; }

	/// <summary>
	/// A secret key, if applicable
	/// </summary>
	public string Secret { get; set; } = string.Empty;
}

