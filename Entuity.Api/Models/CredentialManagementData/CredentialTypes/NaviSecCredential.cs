using Entuity.Api.Enums;
using Entuity.Api.JsonConverters;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.CredentialManagementData.CredentialTypes;

/// <summary>
/// Holds a NaviSec Credential
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838476426525-Credential-Management-RESTful-API#post'/></para>
/// </summary>
public class NaviSecCredential
{
	/// <inheritdoc cref="NaviSecCredentialScope"/>
	[JsonConverter(typeof(UpperCaseEnumConverter<NaviSecCredentialScope>))]
	public NaviSecCredentialScope Scope { get; set; }

	/// <summary>
	/// The Credential's connection Username
	/// </summary>
	public required string Username { get; set; }

	/// <summary>
	/// The Credential's connection Password
	/// </summary>
	public required string Password { get; set; }
}
