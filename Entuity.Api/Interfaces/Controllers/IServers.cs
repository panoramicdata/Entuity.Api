using Entuity.Api.Models;
using Entuity.Api.Models.Collections;
using Entuity.Api.Models.ReturnItems;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;
/// <summary>
/// Servers
/// see https://support.entuity.com/hc/en-us/articles/13829672195869-Servers-RESTful-API
/// see http://support.entuity.com/hc/en-us/articles/13829704875677-Server-Details-RESTful-API
/// </summary>
public interface IServers
{
	/// <summary>
	/// Get all Servers
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns></returns>
	[Get("/api/servers")]
	Task<Response<Server>> GetAllAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Get details about a specific server
	/// </summary>
	/// <param name="serverId"></param>
	/// <exception cref="Exceptions.ApiException">Thrown when fails to make API call</exception>
	/// <returns></returns>
	[Get("/api/servers/{serverId}")]
	Task<ServerDetails> GetServerDetailsAsync(string serverId, CancellationToken cancellationToken);
}
