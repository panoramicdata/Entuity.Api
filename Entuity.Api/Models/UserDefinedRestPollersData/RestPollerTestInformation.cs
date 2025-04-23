using Entuity.Api.Models.UserDefinedRestPollersData.Post;
using System.Collections;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.UserDefinedRestPollersData;

/// <summary>
/// Holds information for testing a REST poller.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838720753309-User-Defined-REST-Pollers-Testing-RESTful-API#post'/></para>
/// </summary>
public class RestPollerTestInformation
{
	/// <summary>
	/// URL for the REST API to connect to.
	/// </summary>
	public required string Url { get; set; }

	/// <inheritdoc cref="RestPollerCredential"/>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public RestPollerCredential? Credential { get; set; }

	/// <summary>
	/// HTTP method, usually "GET" or "POST".
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? MethodType { get; set; }

	/// <summary>
	/// Optionally overrides the default amount of time the engine will wait before timing out the request (which is 30 seconds)
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? TimeoutSecs { get; set; }

	/// <summary>
	/// Defines the body text to be sent. Only required for POST requests.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public IEnumerable? Headers { get; set; }

	/// <summary>
	/// 	List of prerequisite poller steps to be evaluated before this test can be executed. Each of this defines a complete poller step from a poller. Typically these would establish authentication and/or set the value of one or more variables that will be used during this test.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public IEnumerable? PrerequisiteSteps { get; set; }
}
