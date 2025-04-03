using Entuity.Api.Enums;
using Entuity.Api.JsonConverters;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.CredentialManagementData.CredentialTypes;

/// <summary>
/// Represents a SNMPv3 Credential
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838476426525-Credential-Management-RESTful-API#post'/></para>
/// </summary>
public class SnmpV3Credential
{
	/// <summary>
	/// The SNMPv3 Username
	/// </summary>
	public required string Username { get; set; }

	/// <inheritdoc cref="CredentialAuthenticationType"/>
	[JsonPropertyName("authType")]
	[JsonConverter(typeof(UpperCaseEnumConverter<CredentialAuthenticationType>))]
	public required CredentialAuthenticationType AuthenticationType { get; set; }

	/// <summary>
	/// The Authentication Password for this Credential
	/// </summary>
	[JsonPropertyName("authPassword")]
	public required string AuthenticationPassword { get; set; }

	/// <inheritdoc cref="CredentialEncryptionType"/>
	[JsonConverter(typeof(UpperCaseEnumConverter<CredentialEncryptionType>))]
	public required CredentialEncryptionType EncryptionType { get; set; }

	/// <summary>
	/// The Encryption Password
	/// </summary>
	public required string EncryptionPassword { get; set; }

	/// <summary>
	///  An optional Context for the Credential
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public object? Context { get; set; }
}
