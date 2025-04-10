using Entuity.Api.Interfaces;
using Entuity.Api.Models.CredentialManagementData.CredentialTypes;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.CredentialManagementData.Post.CredentialAttributeSets;

/// <summary>
/// Holds the attributes for a new AWS Credential
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838476426525-Credential-Management-RESTful-API#post'/></para>
/// </summary>
public class NewAwsCredentialAttributes : ICredentialAttributeSet
{
	/// <inheritdoc cref="AwsCredential"/>
	[JsonPropertyName("AwsAttributes")]
	public required AwsCredential AwsAttributes { get; set; }
}
