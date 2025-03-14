namespace Entuity.Api.Models.ReturnItems;

public class WebhookEvent
{
	public string EventName { get; set; } = string.Empty;

	public string EventDescription { get; set; } = string.Empty;

	public int EventID { get; set; }

	public int EventSeverity { get; set; }
}

