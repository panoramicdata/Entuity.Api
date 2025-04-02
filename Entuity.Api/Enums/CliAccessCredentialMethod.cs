using System.Runtime.Serialization;

namespace Entuity.Api.Enums;

/// <summary>
/// Represents the method used to access a CLI Access Credential
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838476426525-Credential-Management-RESTful-API#post'/></para>
/// </summary>
public enum CliAccessCredentialMethod
{
	/// <summary>
	/// Secure Shell Protocol
	/// </summary>
	[EnumMember(Value = "SSH")]
	Ssh,

	/// <summary>
	/// Telecommunication Network Protocol
	/// </summary>
	[EnumMember(Value = "TELNET")]
	Telnet
}
