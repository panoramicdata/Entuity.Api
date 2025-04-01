using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.WebhooksData.Get;

/// <summary>
/// Represents a Rule associated with a Custom Webhook
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13839129543709-Custom-Webhook-Rules-RESTful-API#get'/></para>
/// </summary>
public class CustomWebhookRule : IGetItem
{
	/// <summary>
	/// Id of the Custom Webhook Rule
	/// </summary>
	public int RuleID { get; set; }

	/// <summary>
	/// Name of the Custom Webhook Rule
	/// </summary>
	public string RuleName { get; set; } = string.Empty;

	/// <summary>
	/// Id of the group to which this Custom Webhook Rule applies
	/// </summary>
	public int GroupID { get; set; }

	/// <summary>
	/// Set of conditions that determines whether a Webhook payload meets the requirements for raising a Webhook event
	/// </summary>
	public IEnumerable<Condition> Conditions { get; set; } = [];

	/// <summary>
	/// Set of parameters by which to map the webhook event
	/// </summary>
	public required Eventmapping EventMapping { get; set; }

	/// <summary>
	/// Whether this Rule is active
	/// </summary>
	public int Enabled { get; set; }

	/// <summary>
	/// Unique Id of the payload
	/// </summary>
	public int PayloadID { get; set; }
}
