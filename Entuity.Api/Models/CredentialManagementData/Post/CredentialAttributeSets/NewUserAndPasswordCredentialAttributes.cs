using Entuity.Api.Interfaces;
using Entuity.Api.Models.CredentialManagementData.CredentialTypes;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.CredentialManagementData.Post.CredentialAttributeSets;

/// <summary>
/// Holds the attributes for a new User and Password Credential
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838476426525-Credential-Management-RESTful-API#post'/></para>
/// </summary>
public class NewUserAndPasswordCredentialAttributes : ICredentialAttributeSet
{
	/// <inheritdoc cref="UserAndPasswordCredential"/>
	[JsonPropertyName("UserAndPasswordAttributes")]
	public required UserAndPasswordCredential UserAndPasswordAttributes { get; set; }
}
