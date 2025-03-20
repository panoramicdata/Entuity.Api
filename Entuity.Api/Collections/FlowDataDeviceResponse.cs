using Entuity.Api.Models;

namespace Entuity.Api.Collections;

public class FlowDataDeviceResponse
{
	public IEnumerable<FlowDataDevice> Devices { get; set; } = [];
}
