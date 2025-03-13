using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class IpamTests(EntuityClient client)
{
	[Fact]
	public async Task IpamController_GetAllDhcpServers_Succeeds()
	{
		var dhcpServers = await client
			.Ipam
			.GetAllDhcpServers(CancellationToken.None);

		dhcpServers.Should().NotBeNull();
	}
}
