using Entuity.Api.Interfaces;
using Entuity.Api.Models.CredentialManagementData.CredentialTypes;

namespace Entuity.Api.Models.CredentialManagementData.Post.CredentialAttributeSets;

/// <summary>
/// Holds the attributes for a new SNMPv1 Credential
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838476426525-Credential-Management-RESTful-API#post'/></para>
/// </summary>
public class NewSnmpV1CredentialAttributes : ICredentialAttributeSet
{
	/// <inheritdoc cref="SnmpV1Credential"/>
	public required SnmpV1Credential SnmpV1Attributes { get; set; }
}
