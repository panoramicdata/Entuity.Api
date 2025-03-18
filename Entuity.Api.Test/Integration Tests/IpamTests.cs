using Entuity.Api.Models.PostItems;
using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class IpamTests(EntuityClient client) : TestFixture
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
	public async Task IpamController_CreateDhcpServerAsync_Succeeds()
	{
		var dhcpServer = new DhcpServerCreate
		{
			Name = "Test DHCP Server",
			IpAddress = "1.2.3.4"
		};

		var response = await client
			.Ipam
			.CreateDhcpServerAsync(dhcpServer, default);

		response.Should().NotBeNull();

		// Get all DHCP Servers
		var dhcpServers = await client
			.Ipam
			.GetAllDhcpServersAsync(default);

		var dhcpServerId = dhcpServers.FirstOrDefault(d => d.Name == dhcpServer.Name)?
			.Id;

		dhcpServerId.Should().NotBeNull();

		// Attempt delete
		var deleteResponse = await client
			.Ipam
			.DeleteDhcpServerAsync((int)dhcpServerId!, default);
	}

	[Fact]
	public async Task IpamController_DeleteDhcpServerAsync_Succeeds()
	{
		var dhcpServer = new DhcpServerCreate
		{
			Name = "Test DHCP Server 2",
			IpAddress = "2.3.4.5"
		};

		var response = await client
			.Ipam
			.CreateDhcpServerAsync(dhcpServer, default);

		response.Should().NotBeNull();

		// Get all DHCP Servers
		var dhcpServers = await client
			.Ipam
			.GetAllDhcpServersAsync(default);

		var dhcpServerId = dhcpServers.FirstOrDefault(d => d.Name == dhcpServer.Name)?
			.Id;

		dhcpServerId.Should().NotBeNull();

		// Attempt delete
		var deleteResponse = await client
			.Ipam
			.DeleteDhcpServerAsync((int)dhcpServerId!, default);

		deleteResponse.IsSuccessStatusCode.Should().BeTrue();
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

	[Fact]
	public async Task IpamController_CreateNetworkAsync_Succeeds()
	{
		var network = new NetworkCreate
		{
			Name = "Test Network",
			IpRange = "10.44.3.0/24",
			Description = "",
			UsageMedium = 0
		};

		var response = await client
			.Ipam
			.CreateNetworkAsync(network, default);

		response.Should().NotBeNull();

		// Get all Networks 
		var networks = await client
			.Ipam
			.GetAllNetworksAsync(default);

		var networkId = networks.FirstOrDefault(n => n.Name == network.Name)?
			.Id;

		networkId.Should().NotBeNull();

		// Attempt delete
		var deleteResponse = await client
			.Ipam
			.DeleteNetworkAsync((int)networkId!, default);
	}

	[Fact]
	public async Task IpamController_DeleteNetworkAsync_Succeeds()
	{
		var network = new NetworkCreate
		{
			Name = "Test Network 2",
			IpRange = "10.44.3.1/24",
			Description = "",
			UsageMedium = 0
		};

		var response = await client
			.Ipam
			.CreateNetworkAsync(network, default);

		response.Should().NotBeNull();

		// Get all Networks 
		var networks = await client
			.Ipam
			.GetAllNetworksAsync(default);

		var networkId = networks.FirstOrDefault(n => n.Name == network.Name)?
			.Id;

		networkId.Should().NotBeNull();

		// Attempt delete
		var deleteResponse = await client
			.Ipam
			.DeleteNetworkAsync((int)networkId!, default);

		deleteResponse.IsSuccessStatusCode.Should().BeTrue();
	}
}
