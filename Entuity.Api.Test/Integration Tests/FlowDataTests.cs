using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class FlowDataTests(EntuityClient client)
{
	[Fact]
	public async Task FlowDataController_GetFlowDevicesAsync_Succeeds()
	{
		var flowDevices = await client
			.FlowData
			.GetFlowDevicesAsync(default);

		flowDevices.Should().NotBeNull();
		flowDevices.Devices.Should().NotBeEmpty();
	}

	[Fact]
	public async Task FlowDataController_GetFlowApplicationsAsync_Succeeds()
	{
		var flowApplications = await client
			.FlowData
			.GetFlowApplicationsAsync(default);

		flowApplications.Should().NotBeNull();
		flowApplications.Applications.Should().NotBeEmpty();
	}

	[Fact]
	public async Task FlowDataController_GetFlowHistoryAsync_Succeeds()
	{
		var history = await client
			.FlowData
			.GetFlowHistoryAsync(1, default);

		history.Should().NotBeNull();
		history.SampleSets.Should().NotBeEmpty();
	}
}
