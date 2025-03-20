using Entuity.Api.Collections;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface IFlowData
{
	[Get("/api/flowDevices")]
	public Task<FlowDataDeviceResponse> GetFlowDevicesAsync(CancellationToken cancellationToken);

	[Get("/api/flowApplications")]
	public Task<FlowApplicationResponse> GetFlowApplicationsAsync(CancellationToken cancellationToken);

	[Get("/api/flowHistory/{id}")]
	public Task<FlowHistoryResponse> GetFlowHistoryAsync(
		[AliasAs("id")] int deviceId,
		CancellationToken cancellationToken);
}
