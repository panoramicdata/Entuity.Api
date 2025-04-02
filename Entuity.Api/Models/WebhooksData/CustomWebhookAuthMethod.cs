namespace Entuity.Api.Models.WebhooksData;

/// <summary>
/// Holds information about Authentication for a Custom Webhook Group
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838941318941-Custom-Webhook-Groups-RESTful-API#get'/></para>
/// </summary>
public class CustomWebhookAuthMethod
{
	/// <summary>
	/// The type of authentication, represented by an Integer. The options are as follows:
	/// <list type="bullet">
	/// <item>1 = basic</item>
	/// <item>3 = API Key Header</item>
	/// <item>4 = API Key Body</item>
	/// <item>5 = API Key Query</item>
	/// </list>
	/// </summary>
	public int AuthType { get; set; }

	/// <summary>
	/// Name of the authentication Key. This field is not applicable if the Basic Authentication type (value 1) is selected.
	/// </summary>
	public string AuthKey { get; set; } = string.Empty;
}
