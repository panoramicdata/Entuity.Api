using System.Text.Json.Serialization;

namespace Entuity.Api.Models.WebhooksData.Post;

/// <summary>
/// Holds information needed to create a new Custom Webhook Group
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838941318941-Custom-Webhook-Groups-RESTful-API#post'/></para>
/// </summary>
public class CustomWebhookGroupCreate
{
	/// <summary>
	/// The name of the Custom Webhook Group. This name must be unique within the system.
	/// </summary>
	public required string GroupName { get; set; }

	/// <inheritdoc cref="CustomWebhookAuthMethodCreate"/>
	[JsonPropertyName("authMethod")]
	public required CustomWebhookAuthMethodCreate AuthenticationMethod { get; set; }
}
