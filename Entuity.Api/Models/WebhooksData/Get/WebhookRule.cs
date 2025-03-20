using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.WebhooksData.Get;

public class WebhookRule : IGetItem
{
	public int RuleID { get; set; }

	public string RuleName { get; set; } = string.Empty;

	public int GroupID { get; set; }

	public IEnumerable<Condition> Conditions { get; set; } = [];

	public required Eventmapping EventMapping { get; set; }

	public int Enabled { get; set; }

	public int PayloadID { get; set; }
}
