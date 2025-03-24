using System.Text.Json.Serialization;

namespace Entuity.Api.Models.UserDefinedRestPollersData;

public class PollerStep
{
	public string PollerStepType { get; set; } = string.Empty;

	public string StepName { get; set; } = string.Empty;

	[JsonPropertyName("authDetails")]
	public required AuthenticationDetails AuthenticationDetails { get; set; }

	[JsonPropertyName("endpointURLSample")]
	public string EndpointUrlSample { get; set; } = string.Empty;

	public string Host { get; set; } = string.Empty;

	public string ApiPath { get; set; } = string.Empty;

	public string MethodType { get; set; } = string.Empty;

	public string Port { get; set; } = string.Empty;

	[JsonPropertyName("useSSL")]
	public bool UseSsl { get; set; }

	public required AttributeMappings AttributeMappings { get; set; }

}