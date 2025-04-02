using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.WebhooksData.Get;

/// <summary>
/// Holds information about a Custom Webhook Group
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838941318941-Custom-Webhook-Groups-RESTful-API#get'/></para>
/// </summary>
public class CustomWebhookGroup : IGetItem
{
	/// <summary>
	/// ID of the Group
	/// </summary>
	public int GroupID { get; set; }

	/// <summary>
	/// The name of the Group
	/// </summary>
	public string GroupName { get; set; } = string.Empty;

	/// <inheritdoc cref="CustomWebhookAuthMethod"/>
	public required CustomWebhookAuthMethod AuthMethod { get; set; }

	/// <summary>
	/// Number of Custom Webhook Endpoints in this Group
	/// </summary>
	public int EndpointCount { get; set; }

	/// <summary>
	/// Number of Webhook rules associated with this Custom Webhook Group
	/// </summary>
	public int RuleCount { get; set; }
}
