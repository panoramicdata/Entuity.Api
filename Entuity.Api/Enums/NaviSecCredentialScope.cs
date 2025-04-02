using System.Runtime.Serialization;

namespace Entuity.Api.Enums;
/// <summary>
/// The Scope of the Credential
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838476426525-Credential-Management-RESTful-API#post'/></para>
/// </summary>
public enum NaviSecCredentialScope
{
	/// <summary>
	/// Global Access
	/// </summary>
	[EnumMember(Value = "GLOBAL")]
	Global,

	/// <summary>
	/// Local Access
	/// </summary>
	[EnumMember(Value = "LOCAL")]
	Local,

	/// <summary>
	/// Lightweight Directory Access Protocol
	/// </summary>
	[EnumMember(Value = "LDAP")]
	Ldap
}
