namespace Entuity.Api.Models;


public class WebhookPayload
{
	public string Payload { get; set; } = string.Empty;

	public int EndpointID { get; set; }

	public string EndpointName { get; set; } = string.Empty;

	public int ObjectID { get; set; }

	public string MediaType { get; set; } = string.Empty;

	public int Timestamp { get; set; }

	public string GroupName { get; set; } = string.Empty;

	public int PayloadID { get; set; }
}

