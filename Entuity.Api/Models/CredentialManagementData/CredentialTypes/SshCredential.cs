using System.Text.Json.Serialization;

namespace Entuity.Api.Models.CredentialManagementData.CredentialTypes;

/// <summary>
/// Holds a Secure Shell Credential
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838476426525-Credential-Management-RESTful-API#post'/></para>
/// </summary>
public class SshCredential
{
	/// <summary>
	/// The Username for this SSH Credential
	/// </summary>
	public required string Username { get; set; }

	/// <summary>
	/// The Password for this SSH Credential
	/// </summary>
	/// <remarks><strong>NOTE:</strong> Only one of Password or SshKey must be specified</remarks>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Password { get; set; }

	/// <summary>
	/// The SSH Key for this SSH Credential. 
	/// </summary>
	/// <remarks><strong>NOTE:</strong> Only one of Password or SshKey must be specified</remarks>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? SshKey { get; set; }
}
