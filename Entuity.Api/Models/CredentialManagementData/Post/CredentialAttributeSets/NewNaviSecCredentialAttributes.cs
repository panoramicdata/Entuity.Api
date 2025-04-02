using Entuity.Api.Interfaces;
using Entuity.Api.Models.CredentialManagementData.CredentialTypes;

namespace Entuity.Api.Models.CredentialManagementData.Post.CredentialAttributeSets;

/// <summary>
/// Holds the attributes for a new NaviSec Credential
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838476426525-Credential-Management-RESTful-API#post'/></para>
/// </summary>
public class NewNaviSecCredentialAttributes : ICredentialAttributeSet
{
	/// <inheritdoc cref="NaviSecCredential"/>
	public required NaviSecCredential NaviSecAttributes { get; set; }
}
