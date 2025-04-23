using System.Text.Json.Serialization;

namespace Entuity.Api.Models.UserDefinedRestPollersData.Post;

/// <summary>
/// Represents the results of a REST poller test.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838720753309-User-Defined-REST-Pollers-Testing-RESTful-API#post'/></para>
/// </summary>
public class RestPollerTestResults
{
	/// <summary>
	/// Code returned by the Entuity collection engine. One of "OK", "WARN" or "ERROR".
	/// </summary>
	public required string ReturnCode { get; set; }

	/// <summary>
	/// Error code from the collection engine. May contain useful error information in the event of internal errors.
	/// </summary>
	public object? ErrorCode { get; set; }

	/// <summary>
	/// Internal ID used for this request by the collection engine.
	/// </summary>
	public required string RequestId { get; set; }

	/// <summary>
	/// Additional information from the collection engine.
	/// </summary>
	[JsonPropertyName("$type")]
	public object? Type { get; set; }

	/// <summary>
	/// Timestamp that the response was created.
	/// </summary>
	public long TimeStamp { get; set; }

	/// <summary>
	/// Lapsed time in milliseconds processing the API request.
	/// </summary>
	public int LapsedTimeMs { get; set; }

	/// <summary>
	/// List of error messages.
	/// </summary>
	public IEnumerable<Message> Messages { get; set; } = [];

	/// <summary>
	/// HTTP code returned from the REST API endpoint.
	/// </summary>
	public int? HttpCode { get; set; }

	/// <summary>
	/// Empty string if HTTP request was a success, or an error string if an error occurred.
	/// </summary>
	public string? HttpErrorMessage { get; set; }

	/// <summary>
	/// Body of the HTTP response if successful. This will usually be a JSON or XML string, but in some cases APIs return HTML or other data.
	/// </summary>
	public string? HttpBody { get; set; }

	/// <summary>
	/// List of HTTP headers in the response, as name-value pairs.
	/// </summary>
	public object? HttpHeaders { get; set; }

	/// <summary>
	/// List of HTTP cookies returned in the response. This have a name, a value and a list of properties.
	/// </summary>
	public object? HttpCookies { get; set; }

	/// <summary>
	/// List of variables available to subsequent poller steps. This can be null, or a list of name-value pairs.
	/// </summary>
	public object? Variables { get; set; }
}
