namespace Entuity.Api.Models.FlowData.Get;

/// <summary>
/// Represents a device that is configured to support flow
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13835526973469-Flow-Data-Listing-Devices-with-Stored-Flow-Information-RESTful-API#get'/></para>
/// </summary>
public class FlowDataDevice
{
	/// <summary>
	/// Id of the flow server that is collecting flow for this device
	/// </summary>
	public Guid FlowServerId { get; set; }

	/// <summary>
	/// Name of the zone that the device has been placed in
	/// </summary>
	public string? ZoneName { get; set; }

	/// <summary>
	/// ID of the device as assigned when the device is taken under management by Entuity
	/// </summary>
	public int DeviceId { get; set; }

	/// <summary>
	/// String representation of the management IP address of the device. Either IpV4 or IpV6
	/// </summary>
	public required string IpAddress { get; set; }

	/// <summary>
	/// Name of the Device
	/// </summary>
	public string DeviceName { get; set; } = string.Empty;

	/// <summary>
	/// StormWorks  Object Id
	/// </summary>
	public int SwObjId { get; set; }

	/// <summary>
	/// Indicates that the flow record originates from a VMWare virtualized device
	/// </summary>
	public bool Vxlan { get; set; }

	/// <summary>
	/// List of port ifindexes for which flow is being collected
	/// </summary>
	public IEnumerable<int> IfIndexes { get; set; } = [];
}
