using System.Text.Json.Serialization;

namespace Entuity.Api.Models.UserDefinedRestPollersData;

/// <summary>
/// Holds information about a step in a REST poller
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838655745565-User-Defined-REST-Poller-Details-RESTful-API#get'/></para>
/// </summary>
public class PollerStep
{
	/// <summary>
	/// Type of poller step
	/// </summary>
	public string PollerStepType { get; set; } = string.Empty;

	/// <summary>
	/// Name of the step. Must be unique within the poller and consists only of alphanumeric characters and underscores
	/// </summary>
	public string StepName { get; set; } = string.Empty;

	/// <summary>
	/// Authentication method for this poller step
	/// </summary>
	[JsonPropertyName("authDetails")]
	public required AuthenticationDetails AuthenticationDetails { get; set; }

	/// <summary>
	/// example URL entered in the UI. Can be omitted or left blank for Rest API calls
	/// </summary>
	[JsonPropertyName("endpointURLSample")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? EndpointUrlSample { get; set; } = string.Empty;

	/// <summary>
	/// Host to connect to. Use "${host}" to automatically use the host of the device the poller is running under, or a fixed string to always connect to the same host
	/// </summary>
	public string Host { get; set; } = string.Empty;

	/// <summary>
	/// Path part of the Rest API URL, including any query part and any interpolated values of the form ${placeholder}
	/// </summary>
	public string ApiPath { get; set; } = string.Empty;

	/// <summary>
	/// HTTP request method, either "GET" or "POST"
	/// </summary>
	public string MethodType { get; set; } = string.Empty;

	/// <summary>
	/// Port number to connect to. Can be omitted for the default HTTP or HTTPS ports 80 / 443 based on the useSSL value
	/// </summary>
	public string Port { get; set; } = string.Empty;

	/// <summary>
	/// Either "true" or "false" depending on whether the request should be made using HTTPS or HTTP
	/// </summary>
	[JsonPropertyName("useSSL")]
	public bool UseSsl { get; set; }

	/// <inheritdoc cref="UserDefinedRestPollersData.AttributeMappings"/>
	public required AttributeMappings AttributeMappings { get; set; }

}