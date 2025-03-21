namespace Entuity.Api.Models.FlowData.Get;

/// <summary>
/// Represents a response that contains the devices that are configured to support flow
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13835526973469-Flow-Data-Listing-Devices-with-Stored-Flow-Information-RESTful-API#get'/></para>
/// </summary>
public class FlowDataDeviceResponse
{
	/// <summary>
	/// The devices that are configured to support flow
	/// </summary>
	public IEnumerable<FlowDataDevice> Devices { get; set; } = [];
}
