using Entuity.Api.Models.CredentialManagementData.Post.CredentialAttributeSets;

namespace Entuity.Api.Models.UserDefinedRestPollersData.Post;

/// <summary>
/// Credential information required for REST Poller authentication.
/// </summary>
public class RestPollerCredential
{
	/// <inheritdoc cref="UserAndPasswordCredentialAttributes"/>
	public required UserAndPasswordCredentialAttributes Attributes { get; set; }
}