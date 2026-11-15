using Entuity.Api.Models.IpamData.Post;
using Entuity.Api.Models.IpamData.Update;
using AwesomeAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class IpamTests(EntuityClient client) : TestFixture
{
	[Fact]
	public async Task IpamController_GetIpamAsync_Succeeds()
	{
		var ipam = await client.Ipam.GetIpamSettingsAndStatus(default);

		ipam.Should().NotBeNull();
	}

	[Fact]
	public async Task IpamController_StartScanOfIpamNetworksAsync_Succeeds()
	{
		var response = await client.Ipam.StartScanOfIpamNetworksAsync(default);

		response.Should().NotBeNull();
	}

	[Fact]
	public async Task IpamController_UpdateIpamSettingsAsync_Succeeds()
	{
		var response = await client.Ipam.GetIpamSettingsAndStatus(default);

		response.Should().NotBeNull();

		var currentActiveTimeFrameHours = response.Settings.ActiveTimeframeHours;

		var update = new IpamSettingsUpdate { ActiveTimeframeHours = currentActiveTimeFrameHours + 1 };

		(await client.Ipam.UpdateIpamSettingsAsync(update, default)).Should().NotBeNull();

		update.ActiveTimeframeHours = currentActiveTimeFrameHours;

		(await client.Ipam.UpdateIpamSettingsAsync(update, default)).Should().NotBeNull();
	}

	[Fact]
	public async Task IpamController_GetAllDhcpServersAsync_Succeeds()
	{
		var dhcpServers = await client.Ipam.GetAllDhcpServersAsync(default);

		dhcpServers.Should().NotBeNull();
	}

	[Fact]
	public async Task IpamController_GetDhcpServerAsync_Succeeds()
	{
		var dhcpServers = await client.Ipam.GetAllDhcpServersAsync(default);

		dhcpServers.Should().NotBeNull();

		foreach (var dhcpServer in dhcpServers)
		{
			(await client.Ipam.GetDhcpServerAsync(dhcpServer.Id, default)).Should().NotBeNull();
		}
	}

	[Fact]
	public async Task IpamController_CreateDhcpServerAsync_Succeeds()
	{
		var id = await CreateDhcpServerAsync("Test DHCP Server", TestAddresses.V4(1, 2, 3, 4));

		await client.Ipam.DeleteDhcpServerAsync(id, default);
	}

	[Fact]
	public async Task IpamController_DeleteDhcpServerAsync_Succeeds()
	{
		var id = await CreateDhcpServerAsync("Test DHCP Server 2", TestAddresses.V4(2, 3, 4, 5));

		var deleteResponse = await client.Ipam.DeleteDhcpServerAsync(id, default);

		deleteResponse.IsSuccessStatusCode.Should().BeTrue();
	}

	[Fact]
	public async Task IpamController_GetAllNetworksAsync_Succeeds()
	{
		var networks = await client.Ipam.GetAllNetworksAsync(default);

		networks.Should().NotBeNull();
	}

	[Fact]
	public async Task IpamController_GetNetworkAsync_Succeeds()
	{
		var networks = await client.Ipam.GetAllNetworksAsync(default);

		networks.Should().NotBeNull();

		foreach (var network in networks)
		{
			(await client.Ipam.GetNetworkAsync(network.Id, default)).Should().NotBeNull();
		}
	}

	[Fact]
	public async Task IpamController_CreateNetworkAsync_Succeeds()
	{
		var id = await CreateNetworkAsync("Test Network", "10.44.3.0/24");

		await client.Ipam.DeleteNetworkAsync(id, default);
	}

	[Fact]
	public async Task IpamController_UpdateNetworkAsync_Succeeds()
	{
		var id = await CreateNetworkAsync("Test Network", "10.44.5.0/24");

		var updateNetwork = new IpamNetworkUpdate
		{
			Name = "Updated Network",
			IpRange = "10.44.5.0/24",
			Description = "Updated Description",
		};

		updateNetwork.Should().NotBeNull();

		await client.Ipam.DeleteNetworkAsync(id, default);
	}

	[Fact]
	public async Task IpamController_DeleteNetworkAsync_Succeeds()
	{
		var id = await CreateNetworkAsync("Test Network 2", "10.44.3.1/24");

		var deleteResponse = await client.Ipam.DeleteNetworkAsync(id, default);

		deleteResponse.IsSuccessStatusCode.Should().BeTrue();
	}

	[Fact]
	public async Task IpamController_GetScannedIpAddressPagesAsync_Succeeds()
	{
		var networks = await client.Ipam.GetAllNetworksAsync(default);

		networks.Should().NotBeNull();

		foreach (var network in networks)
		{
			(await client.Ipam.GetScannedIpAddressPagesAsync(network.Id, default)).Should().NotBeNull();
		}
	}

	private async Task<int> CreateDhcpServerAsync(string name, string address)
	{
		var response = await client.Ipam.CreateDhcpServerAsync(new DhcpServerCreate { Name = name, IpAddress = address }, default);

		response.Should().NotBeNull();

		var dhcpServers = await client.Ipam.GetAllDhcpServersAsync(default);

		var id = dhcpServers.FirstOrDefault(d => d.Name == name)?.Id;

		id.Should().NotBeNull();

		return id!.Value;
	}

	private async Task<int> CreateNetworkAsync(string name, string range)
	{
		var network = new NetworkCreate { Name = name, IpRange = range, Description = "", UsageMedium = 0 };

		(await client.Ipam.CreateNetworkAsync(network, default)).Should().NotBeNull();

		var networks = await client.Ipam.GetAllNetworksAsync(default);

		var id = networks.FirstOrDefault(n => n.Name == name)?.Id;

		id.Should().NotBeNull();

		return id!.Value;
	}
}
