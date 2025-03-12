using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class FlowDataTests(EntuityClient client)
{
	[Fact]
	public async Task FlowDataController_GetFlowDevicesAsync_Succeeds()
	{
		var flowDevices = await client
			.FlowData
			.GetFlowDevicesAsync();

		flowDevices.Should().NotBeNull();
		flowDevices.Devices.Should().NotBeEmpty();
	}
}
