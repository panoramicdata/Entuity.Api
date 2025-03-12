using Entuity.Api.Models;
using Refit;

namespace Entuity.Api.Interfaces;

public interface IFlowData
{
	[Get("/api/flowDevices")]
	public Task<FlowDataDeviceResponse> GetFlowDevicesAsync();
}
