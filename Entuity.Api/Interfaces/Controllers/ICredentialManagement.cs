using Entuity.Api.Collections;
using Entuity.Api.Models.CredentialManagementData.Get;
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
}
