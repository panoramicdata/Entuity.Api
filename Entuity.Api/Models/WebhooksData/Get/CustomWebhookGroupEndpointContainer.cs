using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.WebhooksData.Get;

/// <summary>
/// Holds a list of Endpoints for a Custom Webhook Group
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13839312520349-Custom-Webhook-Endpoint-Details-by-Group-RESTful-API#get'/></para>
/// </summary>
public class CustomWebhookGroupEndpointContainer : IGetItem
{
	/// <summary>
	/// The unique ID of the Custom Webhook Group
	/// </summary>
	public int ContainerID { get; set; }

	/// <summary>
	/// The name of the Custom Webhook Group
	/// </summary>
	public string ContainerName { get; set; } = string.Empty;

	/// <summary>
	/// A Collection of Endpoints for the Custom Webhook Group
	/// </summary>
	public IEnumerable<CustomWebhookGroupEndpoint> Endpoints { get; set; } = [];
}
