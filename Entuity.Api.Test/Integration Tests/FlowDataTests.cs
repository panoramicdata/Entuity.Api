using Entuity.Api.QueryParameters;
using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class FlowDataTests(EntuityClient client) : TestFixture
{
	[Fact]
	public async Task FlowDataController_GetFlowDevicesAsync_Succeeds()
	{
		var flowDevices = await client
			.FlowData
			.GetFlowDevicesAsync(default);

		flowDevices.Should().NotBeNull();
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
	}

	[Fact]
	public async Task FlowDataController_GetFlowHistoryAsyncWithStartTimeFilter_Succeeds()
	{
		// Get history for the last 30 minutes
		var history = await client
			.FlowData
			.GetFlowHistoryAsync(1,
			new FlowDataHistoryFilter { StartTime = -1800 },
			default);

		history.Should().NotBeNull();
	}

	[Fact]
	public async Task FlowDataController_GetFlowHistoryAsyncWithIntervalFilter_Succeeds()
	{
		// Get history for the last 30 minutes
		var history = await client
			.FlowData
			.GetFlowHistoryAsync(1,
			new FlowDataHistoryFilter { Interval = 300 },
			default);

		history.Should().NotBeNull();
	}
}
