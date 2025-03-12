using Entuity.Api.Models;
using Refit;

namespace Entuity.Api.Interfaces;

public interface IFlowData
{
	[Get("/api/flowDevices")]
	public Task<FlowDataDeviceResponse> GetFlowDevicesAsync(CancellationToken cancellationToken);

	[Get("/api/flowApplications")]
	public Task<FlowApplicationResponse> GetFlowApplicationsAsync(CancellationToken cancellationToken);
}
