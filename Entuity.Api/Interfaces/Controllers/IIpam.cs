using Entuity.Api.Collections;
using Entuity.Api.Models;
using Entuity.Api.Models.GetItems;
using Entuity.Api.Models.IpamData.Get;
using Entuity.Api.Models.IpamData.Post;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface IIpam
{
	[Get("/api/ipam/dhcp")]
	public Task<ListResponse<DhcpServer>> GetAllDhcpServersAsync(CancellationToken cancellationToken);

	[Post("/api/ipam/dhcp")]
	public Task<Message> CreateDhcpServerAsync([Body] DhcpServerCreate dhcpServer, CancellationToken cancellationToken);

	[Get("/api/ipam/dhcp/{id}")]
	public Task<DhcpServerDetailed> GetDhcpServerAsync(int id, CancellationToken cancellationToken);

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
}
