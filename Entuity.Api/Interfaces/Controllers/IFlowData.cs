using Entuity.Api.Models.FlowData.Get;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;

public interface IFlowData
{
	/// <summary>
	/// Get all devices that are configured to support flow.
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/flowDevices")]
	public Task<FlowDataDeviceResponse> GetFlowDevicesAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Get all applications that are configured to support flow.
	/// </summary>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/flowApplications")]
	public Task<FlowApplicationResponse> GetFlowApplicationsAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Get the flow data history for a device.
	/// </summary>
	/// <param name="deviceId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/flowHistory/{id}")]
	public Task<FlowHistoryResponse> GetFlowHistoryAsync(
		[AliasAs("id")] int deviceId,
		CancellationToken cancellationToken);
}
