using Entuity.Api.Enums;
using Entuity.Api.JsonConverters;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.CredentialManagementData.CredentialTypes;

/// <summary>
/// Represents a CLI Access Credential (Config Management Credential)
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838476426525-Credential-Management-RESTful-API#post'/></para>
/// </summary>
public class CliAccessCredential
{
	/// <inheritdoc cref="CliAccessCredentialMethod"/>

	[JsonConverter(typeof(UpperCaseEnumConverter<CliAccessCredentialMethod>))]
	public required CliAccessCredentialMethod Method { get; set; }

	/// <summary>
	/// THe port to connect
	/// </summary>
	public string Port { get; set; } = string.Empty;

	/// <summary>
	/// The Username (if required)
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Username { get; set; }

	/// <summary>
	/// One Password (if required)
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Password1 { get; set; }

	/// <summary>
	/// A Second Password (if required)
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Password2 { get; set; }
}
