using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.WebhooksData.Get;

public class WebhookEvent : IGetItem
{
	public string EventName { get; set; } = string.Empty;

	public string EventDescription { get; set; } = string.Empty;

	public int EventID { get; set; }

	public int EventSeverity { get; set; }
}

