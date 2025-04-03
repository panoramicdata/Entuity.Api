using System.Runtime.Serialization;

namespace Entuity.Api.Enums;

/// <summary>
/// The type of authentication to use for a Credential
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838476426525-Credential-Management-RESTful-API#post'/></para>
/// </summary>
public enum CredentialAuthenticationType
{
	[EnumMember("NONE")]
	None,

	/// <summary>
	/// Message-Digest Algorithm 5
	/// </summary>
	[EnumMember(Value = "MD5")]
	Md5,

	/// <summary>
	/// Secure Hash Algorithm
	/// </summary>
	[EnumMember(Value = "SHA")]
	Sha,

	/// <summary>
	/// Secure Hash Algorithm 224
	/// </summary>
	[EnumMember(Value = "SHA224")]
	Sha224,

	/// <summary>
	/// Secure Hash Algorithm 256
	/// </summary>
	[EnumMember(Value = "SHA256")]
	Sha256,

	/// <summary>
	/// Secure Hash Algorithm 384
	/// </summary>
	[EnumMember(Value = "SHA384")]
	Sha384,

	/// <summary>
	/// Secure Hash Algorithm 512
	/// </summary>
	[EnumMember(Value = "SHA512")]
	Sha512
}
