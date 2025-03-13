using Entuity.Api.Models.Collections;
using Entuity.Api.Models.ReturnItems;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface IIpam
{
	[Get("/api/ipam/dhcp")]
	public Task<ListResponse<DhcpServer>> GetAllDhcpServers(CancellationToken cancellationToken);

	[Get("/api/ipam/network")]
	public Task<ListResponse<Network>> GetAllNetworks(CancellationToken cancellationToken);
}
