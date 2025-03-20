using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.WebhooksData.Get;

public class WebhookGroup : IGetItem
{
	public int GroupID { get; set; }

	public string GroupName { get; set; } = string.Empty;

	public required AuthMethod AuthMethod { get; set; }

	public int EndpointCount { get; set; }

	public int RuleCount { get; set; }
}
