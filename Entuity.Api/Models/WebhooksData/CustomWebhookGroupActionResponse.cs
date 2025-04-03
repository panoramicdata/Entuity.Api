namespace Entuity.Api.Models.WebhooksData;

/// <summary>
/// Represents a response from the Entuity API when performing an action on a Custom Webhook Group.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838941318941-Custom-Webhook-Groups-RESTful-API#post'/></para>
/// </summary>
public class CustomWebhookGroupActionResponse
{
	/// <summary>
	/// The Success count of the request.
	/// </summary>
	public int SuccessCount { get; set; }

	/// <summary>
	/// The Failure count of the request.
	/// </summary>
	public int FailureCount { get; set; }

	/// <summary>
	/// An integer that indicates the status of the request.
	/// </summary>
	public int ErrorCode { get; set; }

	/// <summary>
	/// A string that indicates the status of the request.
	/// </summary>
	public string Message { get; set; } = string.Empty;

	public IEnumerable<object> OtherResults { get; set; } = [];
}
