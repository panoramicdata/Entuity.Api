using Entuity.Api.Models.WebhooksData.Get;

namespace Entuity.Api.Models.WebhooksData;

public class Eventmapping
{
	public int EventMappingID { get; set; }

	public string EventSource { get; set; } = string.Empty;

	public string EventDetails { get; set; } = string.Empty;

	public required WebhookEvent WebhookEvent { get; set; }

	public int EventID { get; set; }

	public string EventName { get; set; } = string.Empty;
}

