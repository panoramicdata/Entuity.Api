namespace Entuity.Api.Models;

public class FlowDataDevice
{
	public Guid FlowServerId { get; set; }

	public string? ZoneName { get; set; }

	public int DeviceId { get; set; }

	public required string IpAddress { get; set; }

	public string DeviceName { get; set; } = string.Empty;

	public int SwObjId { get; set; }

	public bool Vxlan { get; set; }

	public IEnumerable<int> IfIndexes { get; set; } = [];
}
