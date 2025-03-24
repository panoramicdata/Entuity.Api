using System.Text.Json.Serialization;

namespace Entuity.Api.Models.UserDefinedRestPollersData;

public class ComponentDetails
{
	/// <inheritdoc cref="AuthenticationDetails"/>/>
	public required AuthenticationDetails AuthDetails { get; set; }

	/// <summary>
	/// Name of the step. Must be unique within the poller and consists only of alphanumeric characters and underscores
	/// </summary>
	public string StepName { get; set; }

	/// <summary>
	/// Example URL entered in the UI. Can be omitted or left blank for Rest API calls
	/// </summary>
	public string EndpointUrlSample { get; set; }

	/// <summary>
	/// Host to connect to. Use "${host}" to automatically use the host of the device the poller is running under, or a fixed string to always connect to the same host
	/// </summary>
	public string Host { get; set; }

	/// <summary>
	/// Path part of the Rest API URL, including any query part and any interpolated values of the form ${placeholder}
	/// </summary>
	public string ApiPath { get; set; }

	/// <summary>
	/// HTTP request method, either "GET" or "POST"
	/// </summary>
	public string MethodType { get; set; }

	/// <summary>
	/// Port number to connect to. Can be omitted for the default HTTP or HTTPS ports 80 / 443 based on the useSSL value
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? Port { get; set; }

	/// <summary>
	/// Either "true" or "false" depending on whether the request should be made using HTTPS or HTTP
	/// </summary>
	public bool UseSsl { get; set; }

	/// <summary>
	/// Optional starting point for all attribute source paths in this step. Can be omitted or left blank if the full path is specified in each attribute's sourcePath
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? PathToData { get; set; }

	/// <inheritdoc cref="UserDefinedRestPollersData.AttributeMappings"/>
	public AttributeMappings AttributeMappings { get; set; }
}