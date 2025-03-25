using Entuity.Api.Collections;
using Entuity.Api.Models;
using Entuity.Api.Models.IpamData.Get;
using Entuity.Api.Models.IpamData.Post;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface IIpam
{
	/// <summary>
	/// Get all DHCP servers.
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/ipam/dhcp")]
	public Task<ListResponse<DhcpServer>> GetAllDhcpServersAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Create a new DHCP server.
	/// </summary>
	/// <param name="dhcpServer"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Post("/api/ipam/dhcp")]
	public Task<Message> CreateDhcpServerAsync([Body] DhcpServerCreate dhcpServer, CancellationToken cancellationToken);

	/// <summary>
	/// Get a detailed information about a DHCP server by ID
	/// </summary>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/ipam/dhcp/{id}")]
	public Task<DhcpServerDetailed> GetDhcpServerAsync(int id, CancellationToken cancellationToken);

	/// <summary>
	/// Delete a DHCP server by ID
	/// </summary>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Delete("/api/ipam/dhcp/{id}")]
	public Task<IApiResponse> DeleteDhcpServerAsync(int id, CancellationToken cancellationToken);

	[Get("/api/ipam/network")]
	public Task<ListResponse<Network>> GetAllNetworksAsync(CancellationToken cancellationToken);

	[Post("/api/ipam/network")]
	public Task<Message> CreateNetworkAsync([Body] NetworkCreate network, CancellationToken cancellationToken);

	[Get("/api/ipam/network/{id}")]
	public Task<Network> GetNetworkAsync(int id, CancellationToken cancellationToken);

	[Delete("/api/ipam/network/{id}")]
	public Task<IApiResponse> DeleteNetworkAsync(int id, CancellationToken cancellationToken);

	[Get("/api/ipam")]
	public Task<IpamSettingsAndStatusResponse> GetIpamSettingsAndStatus(CancellationToken cancellationToken);
}
