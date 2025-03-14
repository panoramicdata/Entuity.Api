using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class IpamTests(EntuityClient client)
{
	[Fact]
	public async Task IpamController_GetAllDhcpServersAsync_Succeeds()
	{
		var dhcpServers = await client
			.Ipam
			.GetAllDhcpServersAsync(default);

		dhcpServers.Should().NotBeNull();
	}

	[Fact]
	public async Task IpamController_GetDhcpServerAsync_Succeeds()
	{
		var dhcpServers = await client
			.Ipam
			.GetAllDhcpServersAsync(default);

		dhcpServers.Should().NotBeNull();

		foreach (var dhcpServer in dhcpServers)
		{
			var detailedDhcpServer = await client
				.Ipam
				.GetDhcpServerAsync(dhcpServer.Id, default);

			detailedDhcpServer.Should().NotBeNull();
		}
	}

	[Fact]
	public async Task IpamController_GetAllNetworksAsync_Succeeds()
	{
		var networks = await client
			.Ipam
			.GetAllNetworksAsync(default);

		networks.Should().NotBeNull();
	}

	[Fact]
	public async Task IpamController_GetNetworkAsync_Succeeds()
	{
		var networks = await client
			.Ipam
			.GetAllNetworksAsync(default);

		networks.Should().NotBeNull();

		foreach (var network in networks)
		{
			var detailedNetwork = await client
				.Ipam
				.GetNetworkAsync(network.Id, default);
			detailedNetwork.Should().NotBeNull();
		}
	}
}
