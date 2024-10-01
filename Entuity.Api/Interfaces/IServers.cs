using Entuity.Api.Models;
using Refit;

namespace Entuity.Api.Interfaces;
public interface IServers
{
	/// <summary>
	/// Get all Servers
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/servers")]
	Task<ServerResponse> GetAll(CancellationToken cancellationToken);

	/// <summary>
	/// Get details about a specific server
	/// </summary>
	/// <param name="serverId"></param>
	/// <returns></returns>
	[Get("/api/servers/{serverId}")]
	Task<ServerDetails> GetServerDetails(string serverId, CancellationToken cancellationToken);
}
