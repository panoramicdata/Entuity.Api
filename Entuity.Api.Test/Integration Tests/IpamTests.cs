using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class IpamTests(EntuityClient client)
{
	[Fact]
	public async Task IpamController_GetAllDhcpServers_Succeeds()
	{
		var dhcpServers = await client
			.Ipam
			.GetAllDhcpServers(default);

		dhcpServers.Should().NotBeNull();
	}

	[Fact]
	public async Task IpamController_GetAllNetworks_Succeeds()
	{
		var networks = await client
			.Ipam
			.GetAllNetworks(default);

		networks.Should().NotBeNull();
	}
}
