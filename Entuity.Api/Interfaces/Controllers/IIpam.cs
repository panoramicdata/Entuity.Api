using Entuity.Api.Collections;
using Entuity.Api.Models;
using Entuity.Api.Models.IpamData.Get;
using Entuity.Api.Models.IpamData.Post;
using Entuity.Api.Models.IpamData.Update;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface IIpam
{
	/// <summary>
	/// Get IPAM Settings and Status
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/ipam")]
	public Task<IpamSettingsAndStatusResponse> GetIpamSettingsAndStatus(CancellationToken cancellationToken);

	/// <summary>
	/// Start a scan of IPAM networks
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Post("/api/ipam")]
	public Task<Message> StartScanOfIpamNetworksAsync(CancellationToken cancellationToken);

	[Put("/api/ipam")]
	public Task<IpamSettings> UpdateIpamSettingsAsync([Body] IpamSettingsUpdate ipamSettings, CancellationToken cancellationToken);

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

	[Put("/api/ipam/network/{id}")]
	public Task<Network> UpdateNetworkAsync(int id, [Body] IpamNetworkUpdate network, CancellationToken cancellationToken);

	[Delete("/api/ipam/network/{id}")]
	public Task<IApiResponse> DeleteNetworkAsync(int id, CancellationToken cancellationToken);
}
