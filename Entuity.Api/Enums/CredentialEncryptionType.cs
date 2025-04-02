using System.Runtime.Serialization;

namespace Entuity.Api.Enums;

/// <summary>
/// The type of encryption used on a Credential
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838476426525-Credential-Management-RESTful-API#post'/></para>
/// </summary>
public enum CredentialEncryptionType
{
	/// <summary>
	/// No Credential Encryption
	/// </summary>
	[EnumMember(Value = "NONE")]
	None,

	/// <summary>
	/// Triple Data Encryption Standard
	/// </summary>
	/// <remarks>(Note, from Entuity v22.0 GA upwards, Triple DES (3-DES) is no longer supported)</remarks>
	[EnumMember(Value = "TRIPLE_DES")]
	TripleDes,

	/// <summary>
	/// Advanced Encryption Standard (AES) Encryption with a 128-bit key
	/// </summary>
	[EnumMember(Value = "AES")]
	Aes,

	/// <summary>
	/// Advanced Encryption Standard (AES) Encryption with a 256-bit key
	/// </summary>
	[EnumMember(Value = "AES256")]
	Aes256
}
