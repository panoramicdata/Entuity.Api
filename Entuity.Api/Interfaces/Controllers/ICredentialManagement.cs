using Entuity.Api.Collections;
using Entuity.Api.Models;
using Entuity.Api.Models.CredentialManagementData.Get;
using Entuity.Api.Models.CredentialManagementData.Post;
using Entuity.Api.Models.CredentialManagementData.Update;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface ICredentialManagement
{
	/// <summary>
	/// Get all Credentials
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/credential")]
	Task<Response<Credential>> GetAllCredentialsAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Create a new Credential
	/// </summary>
	/// <typeparam name="TCredentialAttributes">The attributes of the new credential</typeparam>
	/// <param name="credentialCreate"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Post("/api/credential")]
	Task<Credential> CreateCredentialAsync<TCredentialAttributes>([Body] CredentialCreate<TCredentialAttributes> credentialCreate, CancellationToken cancellationToken)
		where TCredentialAttributes : ICredentialAttributeSet;


	/// <summary>
	/// Updates a Credential by ID
	/// </summary>
	/// <typeparam name="TCredentialAttributes"></typeparam>
	/// <param name="id"></param>
	/// <param name="credentialUpdate"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Put("/api/credential/{id}")]
	Task<CredentialUpdateResponse> UpdateCredentialAsync<TCredentialAttributes>(int id, [Body] CredentialUpdate<TCredentialAttributes> credentialUpdate, CancellationToken cancellationToken)
		where TCredentialAttributes : ICredentialAttributeSet;

	/// <summary>
	/// Delete a Credential by ID
	/// </summary>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Delete("/api/credential/{id}")]
	Task<Message> DeleteCredentialAsync(int id, CancellationToken cancellationToken);
}
